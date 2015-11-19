module File1

open Microsoft.FSharp.Data.TypeProviders
open FSharp.Data
open FSharp.Data.JsonExtensions
type Duel = JsonProvider<"""http://api.duel.gg/duels/recent/""", SampleIsList = true>

let doit = 
    let lv = JsonValue.Load("""http://api.duel.gg/duels/recent/""")
    match lv with 
    | JsonValue.Array a ->
        for record in a do
            let q = Duel.Parse(record.ToString())
            for player in q.Players do
                printfn "Player found: %s" player.Name
    | _ -> printfn "Failed"
