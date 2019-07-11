﻿/*
 * Developer    : Willy Kimura (WK)
 * Library      : BootMeUp
 * License      : MIT
 * 
 * 'BootMeUp' is a library that was inspired by the need for.NET 
 * developers to have a one-stop solution when it comes to 
 * automatic launching of their applications at system startup.
 * Having come across a number of SO (StackOverflow) questions 
 * regarding this topic or revolving around it together with 
 * the many decentralized, undocumented and standalone ways 
 * of incorporating this feature, I saw the desperate of many
 * and so took to building an all-inclusive library that 
 * caters for 'all-things-startup' in .NET applications. 
 * So I built this nifty little library does just that and 
 * even more. Do check it out and try it with your apps!
 * 
 * Improvements are welcome.
 * 
 */


using System;
using Microsoft.Win32;
using System.Reflection;
using System.Diagnostics;
using IWshRuntimeLibrary;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Principal;
using System.ComponentModel.Design;

using WK.Libraries.BootMeUpNS.Models;

namespace WK.Libraries.BootMeUpNS
{
    /// <summary>
    /// A library that provides automatic startup for .NET 
    /// applications at system boot while providing additional 
    /// startup management options.
    /// </summary>
    [DefaultProperty("BootArea")]
    [Designer(typeof(WKDesigner))]
    [Description("A .NET library that provides automatic startup for " +
                 "applications at system boot while providing additional " +
                 "startup management options.")]
    public partial class BootMeUp : Component
    {
        #region Constructor

        /// <summary>
        /// Creates a new <see cref="BootMeUp"/> instance.
        /// </summary>
        public BootMeUp()
        {
            InitializeComponent();

            SetDefaults();
        }

        /// <summary>
        /// Creates a new <see cref="BootMeUp"/> instance.
        /// </summary>
        /// <param name="container">
        /// The container control that will host the component.
        /// </param>
        public BootMeUp(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            SetDefaults();
        }

        #endregion

        #region Fields

        private bool _enableBooting = true;
        private ContainerControl _containerControl = null;
        private const string _subKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        
        #endregion

        #region Enumerations

        /// <summary>
        /// Provides a list of supported application-booting areas.
        /// </summary>
        public enum BootAreas
        {
            /// <summary>
            /// Uses the System Registry as the booting area.
            /// </summary>
            Registry = 0,

            /// <summary>
            /// Uses the Startup folder as the booting area.
            /// </summary>
            StartupFolder = 1
        }

        /// <summary>
        /// Provides the two standard user options supported
        /// when registering an application for booting.
        /// </summary>
        public enum TargetUsers
        {
            /// <summary>
            /// Registers the application to launch 
            /// whenever the current user is logged-in.
            /// </summary>
            CurrentUser = 0,

            /// <summary>
            /// Registers the application to launch 
            /// whenever any user is logged-in. Please 
            /// note that this may require you to have 
            /// the necessary Administrative privileges 
            /// to successfully complete registering the 
            /// application for startup with all users.
            /// </summary>
            AllUsers = 1
        }

        #endregion

        #region Properties

        #region Browsable

        /// <summary>
        /// Gets or sets a value indicating whether automatic 
        /// booting of the application is enabled.
        /// </summary>
        [Category("Booting Options")]
        [ParenthesizePropertyName(true)]
        [Description("Sets a value indicating whether automatic " +
                     "booting of the application is enabled.")]
        public bool Enabled
        {
            get { return _enableBooting; }
            set {

                _enableBooting = value;

                if (ParentForm == null)
                {
                    Run();
                }

            }
        }

        /// <summary>
        /// Gets or sets the alternative booting area will 
        /// be used when the default booting area fails in 
        /// registering the application.
        /// </summary>
        [Category("Booting Options")]
        [Description("When set to true, the alternative booting " +
                     "area will be used when the default booting " +
                     "area fails in registering the application.")]
        public bool UseAlternativeOnFail { get; set; } = true;

        /// <summary>
        /// Gets or sets the boot area where the application 
        /// will be registered for startup/booting.
        /// </summary>
        [Category("Booting Options")]
        [Description("Sets the boot area where the application " +
                     "will be registered for startup/booting.")]
        public BootAreas BootArea { get; set; } = BootAreas.Registry;

        /// <summary>
        /// Gets or sets the target user to be used when
        /// registering the application for startup. Please 
        /// note that setting the option <see cref="TargetUsers.AllUsers"/> 
        /// may require you to have the necessary Administrative privileges 
        /// to successfully complete registering the application 
        /// for startup with all users.
        /// </summary>
        [Category("Booting Options")]
        [Description("Sets the target user to be used when registering the " +
                     "application for startup. Please note that setting the " +
                     "option 'AllUsers' may require you to have the necessary " +
                     "Administrative privileges to successfully complete " +
                     "registering the application for startup with all users.")]
        public TargetUsers TargetUser { get; set; } = TargetUsers.CurrentUser;

        /// <summary>
        /// Gets or sets a list of options for use when 
        /// creating a shortcut in the 'Startup' folder.
        /// </summary>
        [Category("Booting Options: Extras")]
        [Description("Provides a list of options for use when " +
                     "creating a shortcut in the 'Startup' folder.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ShortcutOptions ShortcutOptions { get; set; } = new ShortcutOptions();

        /// <summary>
        /// Gets or sets the object that contains programmer-
        /// supplied data associated with the component.
        /// </summary>
        [Bindable(true)]
        [Category("Booting Options: Extras")]
        [TypeConverter(typeof(StringConverter))]
        [Description("Sets the object that contains programmer-" +
                     "supplied data associated with the component.")]
        public virtual object Tag { get; set; }

        #endregion

        #region Non-browsable

        /// <summary>
        /// Gets or sets a value indicating whether booting 
        /// for the application was enabled or disabled successfully.
        /// </summary>
        [Browsable(false)]
        public bool Successful { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether booting 
        /// will be enabled or disabled when debugging.
        /// </summary>
        [Browsable(false)]
        public bool RunWhenDebugging { get; set; } = false;

        /// <summary>
        /// Determines whether the application is being 
        /// run with Administrative privileges.
        /// </summary>
        [Browsable(false)]
        public bool AdministrativeMode { get => AdminMode(); }

        /// <summary>
        /// Checks whether the application has a 
        /// shortcut link created in the Startup folder.
        /// </summary>
        [Browsable(false)]
        public bool ShortcutExists { get => System.IO.File.Exists(ShortuctPath); }

        /// <summary>
        /// Gets the path to the application shortuct created 
        /// either when the Registry fails or when the default 
        /// <see cref="BootArea"/> is set to 
        /// <see cref="BootAreas.StartupFolder"/>.
        /// </summary>
        [Browsable(false)]
        public string ShortuctPath
        {
            get => $"{Environment.GetFolderPath(Environment.SpecialFolder.Startup)}" +
                   $"\\{Application.ProductName}.lnk";
        }

        /// <summary>
        /// Gets the exception that was thrown during the 
        /// application's boot registering or unregistering process.
        /// </summary>
        [Browsable(false)]
        public Exception Exception { get; private set; }

        /// <summary>
        /// Gets or sets the parent form.
        /// </summary>
        [Browsable(false)]
        public Form ParentForm
        {
            get {

                if (ContainerControl is Form)
                    return ((Form)ContainerControl);
                else
                    return ContainerControl.FindForm();

            }
            set {

                try
                {
                    if (ContainerControl is Form)
                        ContainerControl = value;
                    else
                        ContainerControl = value.FindForm();
                }
                catch (Exception) { }

            }
        }

        #region Parent Form Management

        /// <summary>
        /// Gets or sets the container control within the parent form.
        /// In most cases, this refers and results to the parent form.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ContainerControl ContainerControl
        {
            get { return _containerControl; }
            set {

                try
                {
                    _containerControl = value;

                    if (_containerControl is Control)
                    {
                        value.FindForm().Load += OnLoadParentForm;
                    }
                    else
                    {
                        ((Form)value).Load += OnLoadParentForm;
                    }
                }
                catch (Exception) { }

            }
        }

        /// <summary>
        /// Overrides the ISite functionality, getting the main or parent
        /// container control in the Form. This is overriden to get the
        /// component's host or parent form.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ISite Site
        {
            get { return base.Site; }
            set {

                base.Site = value;

                if (value == null)
                {
                    return;
                }

                if (value.GetService(typeof(IDesignerHost)) is IDesignerHost host)
                {
                    IComponent componentHost = host.RootComponent;

                    if (componentHost is ContainerControl)
                    {
                        ContainerControl = componentHost as ContainerControl;
                    }
                }
            }
        }

        #endregion

        #endregion

        #endregion

        #region Methods

        #region Public

        #region Registry Management

        /// <summary>
        /// Registers the application based on 
        /// the default provided settings.
        /// </summary>
        public bool Register()
        {
            bool success = false;

            if (BootArea == BootAreas.Registry)
            {
                success = Register(TargetUser);

                if (!success && UseAlternativeOnFail)
                {
                    if (TargetUser == TargetUsers.AllUsers)
                    {
                        success = Register(TargetUsers.CurrentUser);

                        if (!success)
                            success = CreateShortcut();
                    }
                    else
                    {
                        success = CreateShortcut();
                    }
                }
            }
            else if (BootArea == BootAreas.StartupFolder)
            {
                success = CreateShortcut();

                if (!success && UseAlternativeOnFail)
                {
                    if (TargetUser == TargetUsers.AllUsers)
                    {
                        success = Register(TargetUsers.CurrentUser);

                        if (!success)
                            success = CreateShortcut();
                    }
                    else
                    {
                        success = CreateShortcut();
                    }
                }
            }

            Successful = success;

            return success;
        }

        /// <summary>
        /// Unregisters the application based on 
        /// the default provided settings.
        /// </summary>
        public bool Unregister()
        {
            bool success = false;

            if (BootArea == BootAreas.Registry)
            {
                success = Unregister(TargetUser);
                
                if (UseAlternativeOnFail)
                {
                    if (TargetUser == TargetUsers.AllUsers)
                    {
                        Unregister(TargetUsers.CurrentUser);
                        DeleteShortcut();
                    }
                }
            }
            else if (BootArea == BootAreas.StartupFolder)
            {
                success = DeleteShortcut();

                if (UseAlternativeOnFail)
                    Unregister(TargetUser);
            }

            return success;
        }

        /// <summary>
        /// Registers the application based on the target 
        /// user and the default provided settings.
        /// </summary>
        /// <param name="targetUser">
        /// The target user to register with.
        /// </param>
        public bool Register(TargetUsers targetUser)
        {
            try
            {
                RegistryKey key = null;

                if (targetUser == TargetUsers.CurrentUser)
                    key = Registry.CurrentUser.OpenSubKey(_subKey, true);
                else if (targetUser == TargetUsers.AllUsers)
                    key = Registry.LocalMachine.OpenSubKey(_subKey, true);

                using (key)
                {
                    key.SetValue(GetAppName(), "\"" + GetAppPath() + "\"");
                }

                Exception = null;

                return true;
            }
            catch (Exception exception)
            {
                Exception = exception;

                return false;
            }
        }

        /// <summary>
        /// Registers the application based on the target 
        /// user and the default provided settings.
        /// </summary>
        /// <param name="targetUser">
        /// The target user to unregister with.
        /// </param>
        public bool Unregister(TargetUsers targetUser)
        {
            try
            {
                RegistryKey key = null;

                if (targetUser == TargetUsers.CurrentUser)
                    key = Registry.CurrentUser.OpenSubKey(_subKey, true);
                else if (targetUser == TargetUsers.AllUsers)
                    key = Registry.LocalMachine.OpenSubKey(_subKey, true);

                if (KeyExists(targetUser))
                {
                    using (key)
                    {
                        key.DeleteValue(GetAppName(), false);
                    }
                }

                Exception = null;

                return true;
            }
            catch (Exception exception)
            {
                Exception = exception;

                return false;
            }
        }

        /// <summary>
        /// Checks whether the application has a startup 
        /// key created in the System Registry as per the 
        /// <see cref="TargetUser"/> specified.
        /// </summary>
        public bool KeyExists()
        {
            return KeyExists(TargetUser);
        }

        /// <summary>
        /// Checks whether the application has a startup 
        /// key that varies with its current location in 
        /// the System Registry as per the 
        /// <see cref="TargetUser"/> specified.
        /// </summary>
        public bool KeyVaries()
        {
            return KeyVaries(TargetUser);
        }

        /// <summary>
        /// Checks whether the application has a startup 
        /// key that varies with its current location in 
        /// the System Registry.
        /// </summary>
        /// <param name="targetUser">
        /// The target user to check.
        /// </param>
        public bool KeyVaries(TargetUsers targetUser)
        {
            try
            {
                RegistryKey key = null;

                if (targetUser == TargetUsers.CurrentUser)
                    key = Registry.CurrentUser.OpenSubKey(_subKey, true);
                else if (targetUser == TargetUsers.AllUsers)
                    Registry.LocalMachine.OpenSubKey(_subKey, true);

                using (key)
                {
                    string name = GetAppName();
                    string path = key.GetValue(name).ToString().ToLower();

                    if (path.StartsWith("\"") & path.EndsWith("\""))
                    {
                        if (path != "\"" + GetAppPath() + "\"")
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        if (path != GetAppPath())
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks whether the application has a startup 
        /// key created in the System Registry.
        /// </summary>
        /// <param name="targetUser">
        /// The user registry to check.
        /// </param>
        public bool KeyExists(TargetUsers targetUser)
        {
            try
            {
                string path = string.Empty;
                string name = GetAppName();

                RegistryKey key = null;

                if (targetUser == TargetUsers.CurrentUser)
                    key = Registry.CurrentUser.OpenSubKey(_subKey, true);
                else if (targetUser == TargetUsers.AllUsers)
                    Registry.LocalMachine.OpenSubKey(_subKey, true);

                using (key)
                {
                    if (key.GetValue(Application.ProductName) != null)
                        path = key.GetValue(name).ToString().ToLower();

                    if (path.StartsWith("\"") & path.EndsWith("\""))
                    {
                        if (path == "\"" + GetAppPath() + "\"")
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        if (path == GetAppPath())
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Shortcut Management

        /// <summary>
        /// Creates a shortcut for the application.
        /// </summary>
        /// <param name="user">
        /// The user-type target folder.
        /// </param>
        public bool CreateShortcut()
        {
            try
            {
                string iconPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}" +
                                  $"\\{GetAppName()}.ico";

                string description = Application.ProductName;

                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(ShortuctPath);

                Assembly asm = Assembly.GetEntryAssembly();
                object[] attributes =
                    asm.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);

                if (attributes.Length > 0)
                {
                    var descriptionAttribute =
                        (AssemblyDescriptionAttribute)attributes[0];

                    description = descriptionAttribute.Description;
                }

                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.Description = description;
                shortcut.IconLocation = iconPath;

                if (ShortcutOptions.Hotkey != Keys.None)
                    shortcut.Hotkey = ShortcutOptions.Hotkey.ToString();

                if (!string.IsNullOrEmpty(ShortcutOptions.Arguments))
                    shortcut.Arguments = ShortcutOptions.Arguments;

                shortcut.Save();

                System.IO.File.Delete(iconPath);

                Exception = null;

                return true;
            }
            catch (Exception exception)
            {
                Exception = exception;

                return false;
            }
        }

        /// <summary>
        /// Deletes any shortcut created for the application.
        /// </summary>
        /// <param name="user">
        /// The user-type target folder.
        /// </param>
        public bool DeleteShortcut()
        {
            try
            {
                System.IO.File.Delete(ShortuctPath);

                Exception = null;

                return true;
            }
            catch (Exception exception)
            {
                Exception = exception;

                return false;
            }
        }

        #endregion

        #endregion

        #region Private

        /// <summary>
        /// Applies the library-default settings.
        /// </summary>
        private void SetDefaults()
        {
            try
            {
                
            }
            catch (Exception) { }
        }
        
        /// <summary>
        /// Gets the application's name.
        /// </summary>
        /// <returns></returns>
        private string GetAppName()
        {
            return Application.ProductName;
        }

        /// <summary>
        /// Gets the application's path.
        /// </summary>
        /// <returns></returns>
        private string GetAppPath()
        {
            return Application.ExecutablePath;
        }

        /// <summary>
        /// Determines whether the application is 
        /// being run with Administrative privileges.
        /// </summary>
        /// <returns></returns>
        public static bool AdminMode()
        {
            bool isAdmin;

            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);

                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }

            return isAdmin;
        }

        /// <summary>
        /// Parses and applies the user-provided 
        /// booting options for the application.
        /// </summary>
        private void Run()
        {
            if (!DesignMode || RunWhenDebugging)
            {
                if (Enabled)
                {
                    Register();
                }
                else
                {
                    Unregister();
                }
            }
        }

        #endregion

        #endregion

        #region Events

        #region Private

        private void OnLoadParentForm(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                Run();
            }
        }

        #endregion

        #endregion

        #region Smart Tags

        #region Constructor

        /// <summary>
        /// Provides <see cref="FontsInstaller"/> design-time features.
        /// </summary>
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        public class WKDesigner : ComponentDesigner
        {
            private DesignerActionListCollection actionLists;

            /// <summary>
            /// Provides <see cref="FontsInstaller"/> design-time features.
            /// </summary>
            WKDesigner() { }

            // Use pull model to populate smart tag menu.
            public override DesignerActionListCollection ActionLists
            {
                get {

                    if (null == actionLists)
                    {
                        actionLists = new DesignerActionListCollection
                        {
                            new WKComponentActionList(this.Component)
                        };
                    }

                    return actionLists;

                }
            }
        }

        #endregion

        #region Designer

        /// <summary>
        /// Initializes a new instance of the <see cref="WKComponentActionList"/> class.
        /// </summary>
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class WKComponentActionList : DesignerActionList
        {
            #region Setup

            private BootMeUp WKComponent;
            private DesignerActionUIService designerActionUISvc = null;

            public WKComponentActionList(IComponent component) : base(component)
            {
                this.WKComponent = component as BootMeUp;

                // Cache a reference to DesignerActionUIService so 
                // that the DesignerActionList can be refreshed.
                this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) 
                                           as DesignerActionUIService;

                this.AutoShow = false;
            }

            #region Properties Management

            internal static PropertyDescriptor GetPropertyDescriptor(IComponent component, string propertyName)
            {
                return TypeDescriptor.GetProperties(component)[propertyName];
            }

            internal static IDesignerHost GetDesignerHost(IComponent component)
            {
                return (IDesignerHost)component.Site.GetService(typeof(IDesignerHost));
            }

            internal static IComponentChangeService GetChangeService(IComponent component)
            {
                return (IComponentChangeService)component.Site.GetService(typeof(IComponentChangeService));
            }

            internal static void SetValue(IComponent component, string propertyName, object value)
            {
                PropertyDescriptor propertyDescriptor = GetPropertyDescriptor(component, propertyName);
                IComponentChangeService svc = GetChangeService(component);
                IDesignerHost host = GetDesignerHost(component);
                DesignerTransaction txn = host.CreateTransaction();

                try
                {
                    svc.OnComponentChanging(component, propertyDescriptor);
                    propertyDescriptor.SetValue(component, value);
                    svc.OnComponentChanged(component, propertyDescriptor, null, null);
                    txn.Commit();
                    txn = null;
                }

                finally
                {
                    if (txn != null)
                        txn.Cancel();
                }
            }

            #endregion

            #endregion

            #region Action Items

            /// <summary>
            /// Implementation of this abstract method creates Smart Tag items,
            /// associates their targets, and collects them into a list.
            /// </summary>
            public override DesignerActionItemCollection GetSortedActionItems()
            {
                DesignerActionItemCollection items = new DesignerActionItemCollection
                {
                    new DesignerActionHeaderItem("Common Tasks"),

                    new DesignerActionPropertyItem("Enabled",
                                     "Enabled", "Common Tasks",
                                     GetPropertyDescriptor(this.Component, "Enabled").Description),

                    new DesignerActionPropertyItem("BootArea",
                                     "BootArea", "Common Tasks",
                                     GetPropertyDescriptor(this.Component, "BootArea").Description),

                    new DesignerActionPropertyItem("TargetUser",
                                     "TargetUser", "Common Tasks",
                                     GetPropertyDescriptor(this.Component, "TargetUser").Description)
                };

                return items;
            }

            #endregion

            #region Properties

            public bool Enabled
            {
                get { return WKComponent.Enabled; }
                set { SetValue(WKComponent, "Enabled", value); }
            }

            public BootAreas BootArea
            {
                get { return WKComponent.BootArea; }
                set { SetValue(WKComponent, "BootArea", value); }
            }

            public TargetUsers TargetUser
            {
                get { return WKComponent.TargetUser; }
                set { SetValue(WKComponent, "TargetUser", value); }
            }

            #endregion
        }

        #endregion

        #endregion
    }
}