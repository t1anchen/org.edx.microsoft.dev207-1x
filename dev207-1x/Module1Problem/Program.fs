// Learn more about F# at http://fsharp.org

open System

let f (r: float, h: float) : float =
    Math.PI * r*r * h


[<EntryPoint>]
let main argv =
    let height = 10.0
    let radius = 5.0
    let volume = f(radius, height)
    printfn "%f" volume
    0 // return an integer exit code
