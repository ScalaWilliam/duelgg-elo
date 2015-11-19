module File2

type MyClass1(x: int, y: int) =
   do printfn "%d %d" x y
   new() = MyClass1(0, 0)

type OrderId = OrderId of int

type Wat = {
    middleName: string option;
       orderId: OrderId option
}

let x = { middleName = Some("John"); orderId = Some(5 |> OrderId) }
    