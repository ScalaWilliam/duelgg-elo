//#r @"FSharp.Data.TypeProviders.0.0.1\lib\net40\FSharp.Data.TypeProviders.dll"
//#r @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5.2\System.Data.Services.Client.dll"
//// Use the OData type provider to create types that can be used to access the Northwind database.
//// Add References to FSharp.Data.TypeProviders and System.Data.Services.Client
//open Microsoft.FSharp.Data.TypeProviders
//#r @"FSharp.Data.2.2.5\lib\net40\FSharp.Data.dll"
////type Northwind = ODataService<"http://services.odata.org/Northwind/Northwind.svc">
////let db = Northwind.GetDataContext()
////
////
////// A query expression.
////let query1 = query { for customer in db.Customers do
////                     select customer }
////
////
////
////query1
////|> Seq.iter (fun customer -> printfn "Company: %s Contact: %s" customer.CompanyName customer.ContactName)
////
//open FSharp.Data
//open FSharp.Data.JsonExtensions
//
//type Duel = JsonProvider<"""http://api.duel.gg/duels/recent/""", SampleIsList = true>
//
//let lv = JsonValue.Load("""http://api.duel.gg/duels/recent/""")
//
//match lv with 
//| JsonValue.Array a ->
//    for record in a do
//        let q = Duel.Parse(record.ToString())
//        for player in q.Players do
//            printfn "Player found: %s" player.Name
//| _ -> printfn "Failed"
