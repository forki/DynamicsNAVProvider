(*** hide ***)
#I "../../bin"

(**
DynamicsNAVProvider
===================

A Microsoft Dynamics NAV type provider, supporting LINQ queries, schema exploration, individuals and much more besides.

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The library can be <a href="https://nuget.org/packages/DynamicsNAVProvider">installed from NuGet</a>:
      <pre>PM> Install-Package DynamicsNAVProvider</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Example
-------

This example demonstrates the use of the type provider:

*)
// reference the type provider dll
#r "FSharp.Data.DynamicsNAVProvider.dll"
open System
open System.Linq
open FSharp.Data

// configure the Dynamics NAV type provider with a connection string to the db
// and set the company
type NAV = DynamicsNAV<"Data Source=SFORKMANN;Initial Catalog=UWW;Integrated Security=True",
                           Company="Company 1">
let db = NAV.GetDataContext()

// now you have typed access to the whole Dynamics NAV database

// look into the sales headers
for sh in db.``Sales Header`` do
    printfn "%s %s" sh.``Sell-to Customer No.`` sh.``Salesperson Code``

(**

![alt text](img/TypedDynamicsNAV.png "Intellisense for Dynamics NAV")

*)

// Retrieve all companies
for company in db.Company do
    printfn "%s" company.Name
// [fsi: Company 1]
// [fsi: CRONUS International Ltd.]

(**

Samples & documentation
-----------------------

The library comes with comprehensible documentation.

 * [API Reference](reference/index.html) contains automatically generated documentation for all types, modules
   and functions in the library. This includes additional brief samples on using most of the
   functions.
 
Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding new public API, please also 
consider adding [samples][content] that can be turned into a documentation. You might
also want to read [library design notes][readme] to understand how it works.

The library is available under Public Domain license, which allows modification and 
redistribution for both commercial and non-commercial purposes. For more information see the 
[License file][license] in the GitHub repository. 

  [content]: https://github.com/forki/DynamicsNAVProvider/tree/master/docs/content
  [gh]: https://github.com/forki/DynamicsNAVProvider
  [issues]: https://github.com/forki/DynamicsNAVProvider/issues
  [readme]: https://github.com/forki/DynamicsNAVProvider/blob/master/README.md
  [license]: https://github.com/forki/DynamicsNAVProvider/blob/master/LICENSE.md
*)
