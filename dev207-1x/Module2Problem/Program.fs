// Learn more about F# at http://fsharp.org

open System

let isTeenager (name: String, age: int) =
    if age >= 20 then name + " is no longer a teenager"
    elif age > 13 then name + " is a teenager"
    else name + " is a kid"

[<EntryPoint>]
let main argv =
    printfn "%s" (isTeenager("Peter",13))
    printfn "%s" (isTeenager("Nick",14))
    printfn "%s" (isTeenager("Michael",20))

    0 // return an integer exit code

// Result:
// Peter is a kid
// Nick is a teenager
// Michael is no longer a teenager