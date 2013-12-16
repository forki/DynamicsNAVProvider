(*** hide ***)
#I "../../bin"
#r "FSharp.Data.DynamicsNAVProvider.dll"

open System
open System.Linq
open FSharp.Data

// configure the Dynamics NAV type provider with a connection string to the db
type NAV = DynamicsNAV<"Data Source=OMEGA;Initial Catalog=Dev;Integrated Security=True",
                           Company="CRONUS International Ltd.">
let db = NAV.GetDataContext()

(**
DynamicsNAVProvider - Queries
=============================
It's possible to perform LINQ queries against the Dynamics NAV database:

*)

query{ for cus in db.Customer do
       join sh in db.``Sales Header`` on (cus.``No.`` = sh.``Sell-to Customer No.``)
       where (cus.Name.StartsWith "Steffen") 
       select (cus.Name,sh.``No.``,sh.``Currency Code``) } 
  |> Seq.toArray
