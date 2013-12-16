namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("DynamicsNAVProvider")>]
[<assembly: AssemblyProductAttribute("DynamicsNAVProvider")>]
[<assembly: AssemblyDescriptionAttribute("Type providers for Dynamics NAV access.")>]
[<assembly: AssemblyVersionAttribute("0.0.2")>]
[<assembly: AssemblyFileVersionAttribute("0.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.2"
