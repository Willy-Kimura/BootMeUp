# BootMeUp
[![bootmeup-nuget](https://img.shields.io/badge/NuGet-1.0.0-brightgreen.svg)](https://www.nuget.org/packages/BootMeUp/) [![wk-donate](https://img.shields.io/badge/Donate-PayPal-blue.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=DJ8D9CE8BWA3J&source=url)

**BootMeUp** is a .NET library that provides automatic startup for .NET applications at system boot while providing additional startup management options.

![bootmeup-logo](Assets/bootmeup-logo.png)

# Installation
To install via the [NuGet Package Manager](https://www.nuget.org/packages/BootMeUp/) Console, run:

> `Install-Package BootMeUp`

# Features
Here's a comprehensive list of the features available:

- Built as a component making it accessible in Design Mode.
- Supports [.NET Framework 4.0](https://www.microsoft.com/en-us/download/details.aspx?id=17718) and higher.
- Provides support for the major Windows application startup areas: the *Registry* and the *Startup Folder*.
- Provides the ability to create application shortcuts, including *arguments* and *hotkey* setup.
- Registering and unregistering your applications from the startup areas has been made seamless.
- Provides the ability to register your applications in the *current user* (default) domain or *all users* domain (requires Administrative privileges).
- Uses the alternative method for registering your application if the default fails, giving you 100% confidence when deploying your applications when automatic startup is enabled.
- Includes additional properties and methods to help you manage application startups.

# Usage
### Working in Design Mode
If you prefer working with the Designer, once you've installed the package, go to the Toolbox and locate the library, then simply drag-and-drop the component onto your Main Form.

You can then use the *Properties* window to change its options:

![bootmeup-properties](Assets/bootmeup-properties.png)

Once you've completed, that's it! BootMeUp will take care of the rest.

If you want to take it a mile further and provide a *checkbox* option that lets your users either enable or disable automatic booting of your application, simply set the library's property `Enabled` to either `true` or `false` respectively:

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

And that's all! To read more on the various properties implemented, head over to the next section.

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
```

```vb
' VB
Dim bootMeUp As New BootMeUp

bootMeUp.UseAlternativeOnFail = True
bootMeUp.BootArea = BootMeUp.BootAreas.Registry
bootMeUp.TargetUser = BootMeUp.TargetUsers.CurrentUser

' Enable auto-booting.
bootMeUp.Enabled = True
```

You can also check if the registration was successful using the property `Successful`:

```c#
// C#
if (bootMeUp.Successful)
    MessageBox.Show("The program will launch on startup.");
else
    MessageBox.Show("There was an issue. Please try launching as Admin.");
```

```vb
' VB
If bootMeUp.Successful = true Then
    MsgBox("The program will launch on startup.")
Else
    MsgBox("There was an issue. Please try launching as Admin.")
End If
```

Usually, whenever automatic startup fails to be registered correctly with the set defaults, the property `UseAlternativeOnFail` when set to `true` ensures that BootMeUp moves further by:

1. Trying to register the application once again in the `AllUsers` registry domain if the `CurrentUser` is set as the default in the `TargetUser` property or vice-versa.
2. Creating a shortcut for the application in the *Windows Startup* folder which is often most successful and acts as the last option to be executed if all else fails.

This ensures that your application is eventually set to launch on startup, greatly minimizing on the risks of total failure.

However, if all else really fails, you can be sure that the computer requires some serious privileges to complete this action. This therefore means that you can either inform the user to launch the program as an Administrator, or otherwise display an exception using the inbuilt `Exception` property. 

Here are two examples explaining each scenario and how we can go about this:

```c#
// C#: Check if the program was successfully set to boot...
if (bootMeUp.Successful)
    // Inform user...
else
{
    // We will use the AdministrativeMode property
    // to check whether the program was launched
    // with Admin privileges.
    if (bootMeUp.AdministrativeMode == false)
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



