// Learn more about F# at http://fsharp.org

open System

let hexarea t: float =
    (3.0 * Math.Sqrt(3.0) / 2.0) * Math.Pow(t, 2.0)

[<EntryPoint>]
let main argv =

    let value = Console.ReadLine()
    let f = float value
    let calc = hexarea f

    printf "%f" calc

    0 // return an integer exit code
