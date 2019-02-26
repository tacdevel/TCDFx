[![License][Badges.License]][Links.License]
[![Contributors][Badges.Contributors]][Links.Contributors]
![C# Version][Badges.CSharpVersion]
![Target Frameworks][Badges.TargetFrameworks]  
[![Open Issues][Badges.Issues.Open]][Links.Issues.Open]
[![Closed Issues][Badges.Issues.Closed]][Links.Issues.Closed]
[![Help Wanted Issues][Badges.Issues.HelpWanted]][Links.Issues.HelpWanted]
[![Good First Issues][Badges.Issues.GoodFirstIssue]][Links.Issues.GoodFirstIssue]  
[![CodeFactor Status][Badges.CodeFactor]][Links.CodeFactor]
[![Dependabot Status][Badges.Dependabot]][Links.Dependabot]
[![Gitter Chat][Badges.Gitter]][Links.Gitter]

# TCDFx (TCD Framework)

TCDFx (also known as the TCD Framework) is a collection of libraries targeting .NET Standard,
providing APIs for UI application development, alternative P/Invoke types, and other helpful APIs to
make development easier.

For examples, see the `examples\` directory.

## Contributing

Contributing is as easy as filing an issue, fixing a bug, or suggesting a new feature.

For more information about contributing to this project, see the
[CONTRIBUTING.md][Links.Contributing] file.

For all a list of all contributors with some stats about their contributions, see the
[Contributors][Links.Contributors] page.

## Packages

| Package Name                         | CI Build Status/Packages                                                                     | Stable Packages           |
| :----------------------------------- | :------------------------------------------------------------------------------------------- | :------------------------ |
| TCD.Collections.MultiValueDictionary | [![Build Status][Badges.BuildStatus.1]][Links.BuildStatus.1] ![NuGet][Badges.Nuget.Pre.1]    | ![NuGet][Badges.Nuget.1]  |
| TCD.Disposable                       | [![Build Status][Badges.BuildStatus.2]][Links.BuildStatus.2] ![NuGet][Badges.Nuget.Pre.2]    | ![NuGet][Badges.Nuget.2]  |
| TCD.Drawing.Common                   | [![Build Status][Badges.BuildStatus.6]][Links.BuildStatus.6] ![NuGet][Badges.Nuget.Pre.6]    | ![NuGet][Badges.Nuget.6]  |
| TCD.Drawing.Primitives               | [![Build Status][Badges.BuildStatus.3]][Links.BuildStatus.3] ![NuGet][Badges.Nuget.Pre.3]    | ![NuGet][Badges.Nuget.3]  |
| TCD.Drawing.Text                     | [![Build Status][Badges.BuildStatus.7]][Links.BuildStatus.7] ![NuGet][Badges.Nuget.Pre.7]    | ![NuGet][Badges.Nuget.7]  |
| TCD.InteropServices                  | [![Build Status][Badges.BuildStatus.4]][Links.BuildStatus.4] ![NuGet][Badges.Nuget.Pre.4]    | ![NuGet][Badges.Nuget.4]  |
| TCD.Native.Libui*                    | [![Build Status][Badges.BuildStatus.8]][Links.BuildStatus.8] ![NuGet][Badges.Nuget.Pre.8]    | ![NuGet][Badges.Nuget.8]  |
| TCD.UI                               | [![Build Status][Badges.BuildStatus.5]][Links.BuildStatus.5] ![NuGet][Badges.Nuget.Pre.5]    | ![NuGet][Badges.Nuget.5]  |

<sub>* - This package does not contain public members and should not be added directly.</sub>

### Installing TCDFx Packages

All libraries in the TCD Framework are packaged as NuGet Packages (`.nupkg`) and version numbers use
SemVer 2.0.0.

Replace `{PackageName}` with the package you want to use.  
Replace `{PackageVersion}` with the version of the package.

#### Install using Visual Studio

Open the Package Management Console, and enter the following:

```
PM> Install-Package {PackageName} -Version {PackageVersion}
```

#### Install using .NET CLI

Open a terminal (or `Command Prompt` on Windows), and enter the following:

```
dotnet add package {PackageName} --version {PackageVersion}
```

#### Install using a PackageReference

Add the following `<PackageReference />` to your `.csproj`:

```
<PackageReference Include="{PackageName}" Version="{PackageVersion}" />
```

## Building From Source

TCDFx is built with .NET Core 2.1, so you can build the packages with either Visual Studio, Visual
Studio Code, or just by running a couple simple commands. Use the steps below to get started!

### Prerequisites

| Operating System | Prerequisites                                                                                                                                             |
| :--------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Windows 7/8.1/10 | .NET Core 2.1 SDK<br/><br/>**Optional:**<br/>Visual Studio 2017 (v15.9.x)<br/>Visual Studio 2019 (v16.0.x)<br/>Visual Studio Code (With the C# extension) |
| Mac OS X         | .NET Core 2.1 SDK<br/><br/>**Optional:**<br/>Visual Studio Code (With the C# extension)                                                                   |
| Linux            | .NET Core 2.1 SDK<br/><br/>**Optional:**<br/>Visual Studio Code (With the C# extension)                                                                   |

### Build Using Visual Studio (Windows)

*Ensure you have the latest version of Visual Studio 2017/2019 installed with the .NET Core
workload.*

1. Open the `tcdfx.sln` file.
2. Then, navigate to the `Build>Build Solution` menu item.

### Build Using a CLI or Visual Studio Code

Run the following command in a command-line interface in the root directory of this repository:

```
dotnet build .\tcdfx.sln
```

<!-- Badges -->
[Badges.BuildStatus.1]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/source/TCD.Collections.MultiValueDictionary
[Badges.BuildStatus.2]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/source/TCD.Disposable
[Badges.BuildStatus.3]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/source/TCD.Drawing.Primitives
[Badges.BuildStatus.4]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/source/TCD.InteropServices
[Badges.BuildStatus.5]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/source/TCD.UI
[Badges.BuildStatus.6]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/source/TCD.Drawing.Common
[Badges.BuildStatus.7]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/source/TCD.Drawing.Text
[Badges.BuildStatus.8]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/source/TCD.Native.Libui
[Badges.NuGet.1]: https://badgen.net/nuget/v/TCD.Collections.MultiValueDictionary
[Badges.NuGet.2]: https://badgen.net/nuget/v/TCD.Disposable
[Badges.NuGet.3]: https://badgen.net/nuget/v/TCD.Drawing.Primitives
[Badges.NuGet.4]: https://badgen.net/nuget/v/TCD.InteropServices
[Badges.NuGet.5]: https://badgen.net/nuget/v/TCD.UI
[Badges.NuGet.6]: https://badgen.net/nuget/v/TCD.Drawing.Common
[Badges.NuGet.7]: https://badgen.net/nuget/v/TCD.Drawing.Text
[Badges.NuGet.8]: https://badgen.net/nuget/v/TCD.Native.Libui
[Badges.NuGet.Pre.1]: https://badgen.net/nuget/v/TCD.Collections.MultiValueDictionary/pre
[Badges.NuGet.Pre.2]: https://badgen.net/nuget/v/TCD.Disposable/pre
[Badges.NuGet.Pre.3]: https://badgen.net/nuget/v/TCD.Drawing.Primitives/pre
[Badges.NuGet.Pre.4]: https://badgen.net/nuget/v/TCD.InteropServices/pre
[Badges.NuGet.Pre.5]: https://badgen.net/nuget/v/TCD.UI/pre
[Badges.NuGet.Pre.6]: https://badgen.net/nuget/v/TCD.Drawing.Common/pre
[Badges.NuGet.Pre.7]: https://badgen.net/nuget/v/TCD.Drawing.Text/pre
[Badges.NuGet.Pre.8]: https://badgen.net/nuget/v/TCD.Native.Libui/pre
[Badges.License]: https://badgen.net/badge/license/MIT/blue
[Badges.Contributors]: https://badgen.net/github/contributors/tom-corwin/tcdfx
[Badges.CSharpVersion]: https://badgen.net/badge/C%23/7.3/green
[Badges.TargetFrameworks]: https://badgen.net/badge/targets/netstandard2.0/purple
[Badges.Issues.Open]: https://badgen.net/github/open-issues/tom-corwin/tcdfx/
[Badges.Issues.Closed]: https://badgen.net/github/closed-issues/tom-corwin/tcdfx/
[Badges.Issues.HelpWanted]: https://badgen.net/github/label-issues/tom-corwin/tcdfx/help%20wanted/open
[Badges.Issues.GoodFirstIssue]: https://badgen.net/github/label-issues/tom-corwin/tcdfx/good%20first%20issue/open
[Badges.CodeFactor]: https://www.codefactor.io/repository/github/tom-corwin/tcdfx/badge
[Badges.Dependabot]: https://api.dependabot.com/badges/status?host=github&repo=tom-corwin/tcdfx
[Badges.Gitter]: https://badgen.net/badge/chat/on%20gitter/cyan

<!-- Links -->
[Links.BuildStatus.1]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=10
[Links.BuildStatus.2]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=11
[Links.BuildStatus.3]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=12
[Links.BuildStatus.4]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=13
[Links.BuildStatus.5]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=14
[Links.BuildStatus.6]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=15
[Links.BuildStatus.7]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=16
[Links.BuildStatus.8]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=17
[Links.License]: https://github.com/tom-corwin/tcdfx/blob/master/LICENSE.md
[Links.Contributors]: https://github.com/tom-corwin/tcdfx/graphs/contributors
[Links.Issues.Open]: https://github.com/tom-corwin/tcdfx/issues?&q=is%3Aissue+is%3Aopen
[Links.Issues.Closed]: https://github.com/tom-corwin/tcdfx/issues?&q=is%3Aissue+is%3Aclosed
[Links.Issues.HelpWanted]: https://github.com/tom-corwin/tcdfx/issues?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22
[Links.Issues.GoodFirstIssue]: https://github.com/tom-corwin/tcdfx/issues?q=is%3Aissue+is%3Aopen+label%3A%22good+first+issue%22
[Links.CodeFactor]: https://www.codefactor.io/repository/github/tom-corwin/tcdfx
[Links.Dependabot]: https://api.dependabot.com/badges/status?host=github&repo=tom-corwin/tcdfx
[Links.Gitter]: https://gitter.im/tom-corwin/tcdfx?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge
[Links.LibUISharp]: https://github.com/tom-corwin/LibUISharp
[Links.Contributing]: https://github.com/tom-corwin/tcdfx/blob/master/CONTRIBUTING.md
