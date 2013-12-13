module FSharp.Data.DynamicsNAV.Tests

open FSharp.Data.Sql
open System
open System.Linq
open FSharp.Data.Sql

type sql = DynamicsNAV<"Data Source=SFORKMANN;Initial Catalog=UWW;Integrated Security=True">
let ctx = sql.GetDataContext()



for x in ctx.``[dbo].[Test$Bank Branch No_]`` do
    printfn "%A %A" x.City x.``Bank Name``
