open System
open Shape

[<EntryPoint>]
let main argv =


    let shapes =
        [ Circle(5.)
          Square(5.)
          Rectangle(5., 5.)
          Triangle(5., 5.)
          Circle(10.)
          Square(10.)
          Rectangle(10., 5.)
          Triangle(5., 10.) ]

    shapes
    |> List.map calculateArea
    |> List.iter (printfn "%f")

    0 // return an integer exit code
