# Korn [![NuGet](https://img.shields.io/nuget/v/Korn.svg)](https://www.nuget.org/packages/Korn)
Library-Analyzer for additional functionality of NativeAOT\
\
Library makes working with NativeAOT easier.\
So, for example it provides: 
 * **EntryPoint** - Opportunity to make your own native entrypoint method using only one attribute.
 * **Native methods** - easily create native methods and exports.
 * **Ldftn** - method, which return native pointer to method.
 * **Hex** - method, which formatting a string into a byte array.
 * And other functions you can find in the documentation


Also, the library acts as an analyzer. And allows you to create your own sub-analyzers. This opens up the possibility of creating a code-generators and security measures (obfuscation tools, etc.) at the IL/ASM code level.

Installation
------------------------------
1. Download package from NuGet
2. Restart Visual Studio (This is necessary because after installing the nuget, part of the package’s functionality doesn't work)

\
If you install this packges in first time, you also need execute `dotnet build` in terminal (This will trigger events. In which there is an update of Poweshell commands, after it you should open new terminal instance)


Usage
------------------------------
First you need to write in any .cs file of the project `global using static korn;` or add it via global usings. \
\
For build project to native:\
Execute command `korn-build` or just `korn`(сonvenient abbreviation), or execute `dotnet publish` with args, example: `dotnet publish -r win-x64 -c Release`


Contributing / Setup for build
------------------------------
You do not need. Believe me. If you want to create your own analyzer in the same way as I did, don’t.\
As a matter of principle, I do not answer questions about its creation. Only regarding analyzers. But creating it is not worth it.\
You will regret it if you decide to go the same way as me. You don't need it. \
I feel sorry for people who want to do this, just trust me and don’t even start.

Also
------------------------------
The library is intended for x64/x86 build on the latest version of .net. Otherwise, something may not work
