module FSharp.Data.DynamicsNAV.Tests

open System
open System.Linq
open FSharp.Data

type NAV = DynamicsNAV<"Data Source=SFORKMANN;Initial Catalog=UWW;Integrated Security=True",
                           Company="Test">
let db = NAV.GetDataContext()

for bank in db.``Bank Branch No.`` do
    printfn "%s %A" bank.``Bank Name`` bank.``Bank Branch No. Leader``
