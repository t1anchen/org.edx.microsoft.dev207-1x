// Learn more about F# at http://fsharp.org

open System

let rect w h = w * h
let cube w h b = (rect w h) * b

[<EntryPoint>]
let main argv =
    Console.Write("Please enter the width: ")
    let w = Console.ReadLine()
    let w = int w
    Console.Write("Please enter the height: ")
    let h = Console.ReadLine()
    let h = int h
    Console.Write("Please enter the breadth: ")
    let b = Console.ReadLine()
    let b = int b

    let cv = cube w h b
    printfn "%A" cv // Console.WriteLine(cv)

    0 // return an integer exit code
