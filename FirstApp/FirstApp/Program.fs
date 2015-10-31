// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System

let hexarea t : float =
    (3.0 * Math.Sqrt(3.0) / 2.0) * Math.Pow(t, 2.0)


[<EntryPoint>]
let main argv =
    let value = Console.ReadLine()

    let f  = float value

    let calc = hexarea f

    printf "%f" calc

    let res = Console.ReadKey()

    0 // return an integer exit code
