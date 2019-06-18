/*
 * Developer    : Willy Kimura (WK)
 * Library      : BootMeUp
 * License      : MIT
 * 
 * This model lets you create a new Shortcut Options
 * class that is used to provide various options when 
 * creating Windows Application Shortcuts.
 * 
 * Feel free to improve or extend it.
 * 
 */


using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;

namespace WK.Libraries.BootMeUpNS.Models
{
    /// <summary>
    /// Provides a set of options for customizing
    /// created shortcuts in the Startup folder.
    /// </summary>
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ShortcutOptions
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Hotkey to use 
        /// for launching the application.
        /// </summary>
        [Description("Sets the Hotkey to use for " +
                     "launching the application.")]
        [Editor(typeof(ShortcutKeysEditor), typeof(UITypeEditor))]
        public Keys Hotkey { get; set; }

        /// <summary>
        /// Gets or sets the arguments to pass to the application 
        /// when being launched from the shortcut created.
        /// </summary>
        [Description("Sets the arguments to pass to the application " +
                     "when being launched from the shortcut created.")]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Arguments { get; set; }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string containing the list 
        /// of properties and their values.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Hotkey: {Hotkey}, Arguments: " +
                   $"{(string.IsNullOrEmpty(Arguments) ? "None" : Arguments)}";
        }

        #endregion
    }
}