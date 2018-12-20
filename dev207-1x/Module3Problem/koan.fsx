let arr = [| 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
let l = arr.Length
let isEven x = x % 2 = 0

let out =
    seq { for i = 0 to (l-1) do
          if isEven arr.[i] then yield arr.[i] }

let newout = 0 :: (out |> List.ofSeq)

// Result:
// val arr : int [] = [|1; 2; 3; 4; 5; 6; 7; 8; 9|]
// val l : int = 9
// val isEven : x:int -> bool
// val out : seq<int>
// val newout : int list = [0; 2; 4; 6; 8]
