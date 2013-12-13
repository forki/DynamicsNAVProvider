module FSharp.Data.DynamicsNAV.Tests

open System
open System.Linq
open FSharp.Data

type sql = DynamicsNAV<"Data Source=SFORKMANN;Initial Catalog=UWW;Integrated Security=True",
                           Company="Test">
let ctx = sql.GetDataContext()

for bank in ctx.``Bank Branch No.`` do
    printfn "%s %A" bank.``Bank Name`` bank.``Bank Branch No. Leader``
