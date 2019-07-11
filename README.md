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
// Enable or disable automatic booting.
bootMeUp1.Enabled = checkBox1.Checked;
```

Here's an example:

![bootmeup-usage-01](Assets/bootmeup-usage-01.gif)

...and the code:

```c#
// Enable or disable Notes to auto-start.
bootMeUp1.Enabled = chkEnableNotes.Checked;
```

