namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("DynamicsNAVProvider")>]
[<assembly: AssemblyProductAttribute("DynamicsNAVProvider")>]
[<assembly: AssemblyDescriptionAttribute("Type providers for Dynamics NAV access.")>]
[<assembly: AssemblyVersionAttribute("0.1.1")>]
[<assembly: AssemblyFileVersionAttribute("0.1.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.1"
