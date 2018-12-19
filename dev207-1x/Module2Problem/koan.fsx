open System
    
let rec dosomethingrandom x =
    if x = 0 then
        Console.WriteLine(1)
        1
    else
        dosomethingrandom (x - 1) * x

// Execution:
// dosomethingrandom 12;;
//  1
//  val it : int = 479001600