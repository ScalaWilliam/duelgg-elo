module UWot

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

// Use the OData type provider to create types that can be used to access the Northwind database.
// Add References to FSharp.Data.TypeProviders and System.Data.Services.Client
open System
open EventSource4Net
open System.Threading
[<EntryPoint>]
let main argv =
//    printfn "%s" x.ToString()
    let uri = new Uri("http://api.duel.gg/games/live/")
    let es = new EventSource(uri, 5000)
    File2.x.ToString() |> printfn "K => %s"
    es.StateChanged.Add(fun e -> Console.WriteLine("New state: " + e.State.ToString()))
    es.EventReceived.Add(fun e -> Console.WriteLine("--------- Msg received -----------\n" + e.Message.ToString()))
    let ct = new CancellationToken()
    es.Start(ct) |> ignore
    printfn "Launching"
    File1.doit |> ignore
    printfn "Done it"
    printfn "%A" argv
    Console.ReadLine() |> ignore
    0 // return an integer exit code
