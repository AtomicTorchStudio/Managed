AtomicTorch Studio's changes in this fork:
1. `float` -> `double` changed almost everywhere to match WPF API (so it's possible to use WPF code without any conditional compilation for NoesisGUI - but you will need to use Roslyn or any other tool to remap `System.Windows.Controls` to `Noesis` as we do in our engine for [CryoFall](CryoFall.com)).
2. `Noesis.EventArgs` -> `Noesis.NoesisEventArgs` class name changed to ensure there are no conflict between `System.EventArgs` and `Noesis.EventArgs` when we're using both in our C# files (from WPF project without any specific conditional compilation for NoesisGUI).
3. Don't use `Type.TypeHandle` property when it's possible to simply use `Type` instance. AFAIK it's used for compatibility with Mono which is not a concern for us.
4. Added our custom `.csproj` and `.sln` files (you can ignore them as the original files are intact). They don't produce NuGet package and automatically copy the `win-x64` runtime only into the solution directory `Libs/Output` (probably something which you don't want to have but you can also use it adapt for your project needs). Also, our custom `.csproj` file includes `Interactivity` C# code (even if it's not browsable with VS2017 it's still included into the build).

This fork still requires acquiring of the NoesisGUI user license and doesn't violate the original source code license.

NoesisGUI Managed SDK
=====================

This repository contains source code for [NuGet packages](https://www.nuget.org/profiles/NoesisTechnologies) corresponding to the [C# SDK](https://www.noesisengine.com/developers/downloads.php) of [NoesisGUI](https://www.noesisengine.com).

Organization
------------

Packages are subdivided into two big categories: **Noesis** the Core library and **NoesisApp** the application framework used by our [samples](https://github.com/Noesis/Tutorials). The Visual Studio 2017 root solution 'Noesis.sln' contains all the projects for all supported platforms.

* Noesis
  - Core Library
  - Extensions
* NoesisApp
  - Core Framework
  - Displays: Win32, WinRT, X11, UIKit, AppKit, Android...
  - RenderContexts: D3D11, GLX, EGL, NSGL, WGL, MTL...
  - Noesis Theme

Supported platforms
-------------------

* Windows (x86, x64)
* UWP (x86, x64, arm)
* macOS (x64)
* Linux (x64)
* iOS (arm, arm64)
* Android (arm, arm64, x86)

