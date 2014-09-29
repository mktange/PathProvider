namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("PathProvider")>]
[<assembly: AssemblyProductAttribute("PathProvider")>]
[<assembly: AssemblyDescriptionAttribute("Type Provider for navigating through your file system.")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
