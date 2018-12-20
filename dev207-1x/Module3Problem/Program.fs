// Learn more about F# at http://fsharp.org

open System

let GOLDEN_RATIO = (1.0 + Math.Sqrt(5.0)) / 2.0
let calculateRatio x = x * GOLDEN_RATIO

[<EntryPoint>]
let main argv =
    let n = Console.ReadLine()
    let n = int n
    let input =
      [ for i in 1..n do yield Console.ReadLine()]
      |> List.map (fun x -> float x)
    printfn "%A" (Array.ofSeq(input))

    let output =
        input
        |> List.map (fun x -> calculateRatio x)
    
    printfn "%A" output

    0 // return an integer exit code

// Result:
// 5
// 34
// 78
// 12
// 90
// 56
// [|34.0; 78.0; 12.0; 90.0; 56.0|]
// [55.01315562; 126.2066511; 19.41640786; 145.623059; 90.60990337]
