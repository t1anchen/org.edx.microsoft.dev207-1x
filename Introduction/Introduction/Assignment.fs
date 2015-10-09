// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System

let v (r: float, h: float) = 
    2.0 * 3.14 * Math.Pow(r, 2.0) * h

[<EntryPoint>]
let main argv = 
    let r = float (Console.ReadLine())
    let h = float (Console.ReadLine())
    let ret = v r h
    printf "%f" ret
    let dummy = Console.ReadLine()
    0 // return an integer exit code
