# BootMeUp
[![nuget-downloads](https://img.shields.io/nuget/dt/BootMeUp?label=Downloads)](https://www.nuget.org/packages/BootMeUp/) [![wk-donate](https://img.shields.io/badge/BuyMeACoffee-Donate-orange.svg)](https://www.buymeacoffee.com/willykimura)

![bootmeup-logo](Assets/bootmeup-logo.png)

**BootMeUp** is a .NET library that provides automatic startup for .NET applications at system-boot while providing additional startup management options.

# Installation 

To install via the [NuGet Package Manager](https://www.nuget.org/packages/BootMeUp/) Console, run:

> `Install-Package BootMeUp`

# Features
- Built as a component making it accessible in Design Mode.
- Supports [.NET Framework 4.0](https://www.microsoft.com/en-us/download/details.aspx?id=17718) and higher.
- Supports the main Windows startup areas: the *Registry* and the *Startup Folder*.
- Simplified registering/unregistering of applications from the supported startup areas.
- Verifies whether an application has been moved from its original location and updates the registry or existing shortcut appropriately.
- Can register applications in the **Current User** (default) domain or **All Users** domain (requires Admin privileges).
- Provides support for startup parameters when launching an application.
- Uses alternative method of registration if the default fails, giving you 100% confidence when deploying your applications while automatic startup is enabled.
- Includes additional properties and methods to help manage application startups.

# Usage
### Working in Design Mode
If you prefer working with the Designer, once you've installed the package, go to the Toolbox and locate the library, then simply drag-and-drop the component onto your Main Form.

You can then use the *Properties* window to change its options:

![bootmeup-properties](Assets/bootmeup-properties.png)

Once done, you're good to go! BootMeUp will take care of the rest.

If you wish to take it a mile further and provide a *checkbox* option that lets your users either enable or disable automatic booting for your application, simply set the library's `Enabled` property to `true` or `false` respectively:

```c#
// C#: Enable or disable automatic booting.
bootMeUp1.Enabled = checkBox1.Checked;
```

```vb
' VB: Enable or disable automatic booting.
BootMeUp1.Enabled = CheckBox1.Checked
```

Here's an example:

![bootmeup-usage-01](Assets/bootmeup-usage-01.gif)

...and the code:

```c#
// C#: Enable or disable my Notes software to auto-start.
bootMeUp1.Enabled = chkEnableNotes.Checked;
```

```vb
' VB: Enable or disable my Notes software to auto-start.
BootMeUp1.Enabled = ChkEnableNotes.Checked
```

To check whether the application is currently set to run on Windows startup, simply use the same `Enabled` property:

```c#
// C#: Check whether my Notes software is set to auto-start.
if (bootMeUp1.Enabled == true)
    // Do something.
else
    // Do something else...
```

```vb
' VB: Check whether my Notes software is set to auto-start.
If BootMeUp1.Enabled = True Then
    ' Do something.
Else
    ' Do something else.
End If
```

By default, the `Enabled` property acts as a setting that verifies whether your application is boot-enabled or not, so you won't need to have an external verification option for this.

>  Please note that the recommended `TargetUser` to set is the `CurrentUser` option, both when working with the Registry and Windows *Startup* folder. This is because your application **won't** require any Administrative privileges for the boot setting to be applied in the user's computer. Likewise, this is how the many applications we know and love register for automatic booting. However, if you really need to set it to all users, then simply set the `TargetUser` property to `AllUsers` and make sure you inform users to run as an Administrator when applying your application for automatic booting.

And that's really it for the basics! To delve more on other additional features, continue reading...

### Working Programmatically

To begin with, once you've installed the library, ensure you import the namespace `WK.Libraries.BootMeUpNS`:

```c#
// C#
using WK.Libraries.BootMeUpNS;
```

```vb
' VB
Imports WK.Libraries.BootMeUpNS
```

You can then add the following code in your startup Form or class:

```c#
// C#
var bootMeUp = new BootMeUp();
            
bootMeUp.UseAlternativeOnFail = true;
bootMeUp.BootArea = BootMeUp.BootAreas.Registry;
bootMeUp.TargetUser = BootMeUp.TargetUsers.CurrentUser;

// Enable auto-booting.
bootMeUp.Enabled = true;

// Or better yet, use a CheckBox.
bootMeUp.Enabled = chkEnabled.Checked;
```

```vb
' VB
Dim bootMeUp As New BootMeUp

bootMeUp.UseAlternativeOnFail = True
bootMeUp.BootArea = BootMeUp.BootAreas.Registry
bootMeUp.TargetUser = BootMeUp.TargetUsers.CurrentUser

' Enable auto-booting.
bootMeUp.Enabled = True

' Or better yet, use a CheckBox.
bootMeUp.Enabled = ChkEnabled.Checked
```

The `BootArea` property provides two options:

| Option          | Description                                                 |
| --------------- | ----------------------------------------------------------- |
| `Registry`      | The application will be added to the *Registry* area.       |
| `StartupFolder` | The application will be added the Windows *Startup* Folder. |

The `TargetUser` property likewise provides two options:

| Option        | Description                                                  |
| ------------- | ------------------------------------------------------------ |
| `CurrentUser` | The application will be registered under the `HKEY_CURRENT_USER` registry domain. |
| `AllUsers`    | The application will be registered under the `HKEY_LOCAL_MACHINE` registry domain. |

To check whether registration was successful, use the getter property `Successful`:

```c#
// C#
if (bootMeUp.Successful)
    MessageBox.Show("The program will launch on startup.");
else
    MessageBox.Show("There was an issue. Please try launching as Admin.");
```

```vb
' VB
If bootMeUp.Successful = True Then
    MsgBox("The program will launch on startup.")
Else
    MsgBox("There was an issue. Please try launching as Admin.")
End If
```

Now let's talk about the property `UseAlternativeOnFail`...

Whenever automatic startup fails to be registered correctly while the property `UseAlternativeOnFail` is set to `true`, BootMeUp moves further by:

1. **Measure #1:** Trying to register the application to the `AllUsers` registry domain if the `CurrentUser` is the default option or vice-versa.
2. **Measure #2:** Creating a shortcut for the application in the *Windows Startup* folder (which is most often 100% successful) and acts as the last option to be executed if the first measure fails.

These two fall-back measures ensure that your application is eventually set to launch on startup, greatly minimizing on the risks of total failure.

However if all measures eventually fail, you can be sure that the computer requires some serious privileges to complete this action. This could mean that you can then inform the user to launch the program as an Administrator, or otherwise display the issue being raised using the inbuilt `Exception` property. 

Here's an example explaining this scenario and how we can go about it:

```c#
// C#
if (bootMeUp.Successful)
    // Success!
else
{
    // We will use the 'AdminMode' property
    // to check whether the program was launched
    // with Administrative privileges.
    if (bootMeUp.AdminMode == false)
    {
        // If the task requires one to run with Admin privileges,
        // direct the user to do so and complete the action.
        MessageBox.Show("Please try launching as Admin...");
    }
    else
    {
        // If true, then there's a serious issue.
        // Display an Exception message to the user.
        // You may also direct the user to a webpage to fix it.
        MessageBox.Show("There was an issue: \n" + bootMeUp.Exception.Message)
    }
}
```

```vb
' VB
If bootMeUp.Successful = True Then
    ' Success!
Else

    ' We will use the 'AdminMode' property
    ' to check whether the program was launched
    ' with Administrative privileges.
    If bootMeUp.AdminMode = False Then

        ' If the task requires one to run with Admin privileges,
        ' direct the user to do so And complete the action.
        MsgBox("Please try launching as Admin...")

    Else

        ' If true, then there's a serious issue.
        ' Display an Exception message to the user.
        ' You may also direct the user to a webpage to fix it.
        MsgBox("There was an issue: \n" + bootMeUp.Exception.Message)
        
    End If

End If
```

As seen, there are two properties at play here:

- The property `AdminMode` lets you check whether your application is currently being run with Administrative privileges.
- The property `Exception` provides error information regarding the failed addition of the program either to the *Registry* or the Windows *Startup* Folder.

The above scenario will help cater for any issues that may be encountered when setting your application to boot. However as indicated before, there are very less likely chances that this may occur as BootMeUp uses a *fail-retry* mode with all its present startup options to ensure that your application is registered to boot once Windows launches.

#### Additional Properties and Methods

##### Properties

| Property           | Description                                                  |
| ------------------ | ------------------------------------------------------------ |
| `AdminMode`        | As discussed earlier, this property lets you check whether your application is currently being run with Administrative privileges. |
| `RunWhenDebugging` | Gets or sets a value indicating whether booting will be enabled or disabled when debugging. This means that when this property is enabled, your application will be registered for startup in your development machine when debugging from Visual Studio. By default, always set it to `false` unless needed. *Please note that since this property is set to `false` by default, your application won't be enabled or disabled from booting when run in Visual Studio; however, setting it to `true` means that you can enable or disable booting when running in Visual Studio. The recommended option is to run the application independently if you'd prefer to test the booting feature out. This is especially important for those working with the Designer.* |
| `ShortcutPath`     | Gets the path to the application shortcut created either when the Registry fails or when the default `BootArea` is set to `BootAreas.StartupFolder`. |
| `ParentForm`       | Gets or sets the component's parent form. This is mainly necessary when the component is used from the Designer. |
| `Tag`              | Use this property if you wish to add programmer-supplied data associated with the component. |

##### Methods

| Method                       | Description                                                  |
| ---------------------------- | ------------------------------------------------------------ |
| `Register()`                 | Acts as an alternative to the `Enabled` property when set to `true`. It registers an application based on the user-provided settings. |
| `Register(TargetUser)`       | As a variant of the `Register()` method, it allows you to specify the target user to register with while including other user-provided settings. |
| `Unregister()`               | As an alternative to the `Enabled` property when set to `false`, it unregisters an application from the specified boot area. |
| `KeyExists()`                | Checks whether the application has a startup key created in the System Registry as per the default provided `TargetUser`. |
| `KeyExists(TargetUser)`      | Checks whether the application has a startup key created in the System Registry as per a specified `TargetUser`. |
| `KeyVaries()`                | Checks whether the application has a startup key that varies with its current location in the System Registry as per the default provided `TargetUser`. |
| `KeyVaries(TargetUser)`      | Checks whether the application has a startup key that varies with its current location in the System Registry as per a specified `TargetUser`. |
| `CreateShortcut()`           | Creates a shortcut for the application in the default target user's *Startup* folder. |
| `CreateShortcut(TargetUser)` | Creates a shortcut for the application in any specified target user's *Startup* folder. |
| `DeleteShortcut()`           | Deletes any shortcut created for the application in the default target user's *Startup* folder. |
| `DeleteShortcut(TargetUser)` | Deletes any shortcut created for the application in any specified target user's *Startup* folder. |
| `ShortcutExists()`           | Checks whether the application has an existing and active shortcut created in the Windows *Startup* folder. |
| `ShortcutVaries()`           | Determines whether an existing application shortcut points to the current application's location. |
| `ShortcutVaries(TargetUser)` | Determines whether an existing application shortcut points to the current application's location based on a specified target user's *Startup* folder. |

### Any Extras?

The sample C# project that comes with the library can give you an preview of the library in action. You can easily interact with the library's settings to see how it works:

![bootmeup-options](Assets/bootmeup-options.png)

Have fun!

### Donate

If you really like my projects and want to support me, consider donating via [BuyMeACoffee](https://www.buymeacoffee.com/willykimura). All donations are optional and are greatly appreciated. 🙏

*Made with* 😊 *by* [*Willy Kimura*]([https://github.com/Willy-Kimura).