type MyRecord =
    { IP : string
      MAC : string
      FriendlyName : string
      ID : int }
      
let IsMatchByName record1 name =
    match record1 with
    | { FriendlyName = nameFound; ID = _; IP = _ } when nameFound = name -> Some((record1.ID,record1.IP))
    | _ -> None  

let checkmatch input =
    match input with
    | Some((x, y)) -> printfn "%A" x  
    | None -> printfn "%A" "Sorry no match"

let testRecord = {
    IP ="127.0.0.1";
    MAC ="FF:FF:FF:FF:FF:FF";
    FriendlyName = "Home";
    ID = 229229
}

checkmatch (IsMatchByName testRecord "Home1");;

