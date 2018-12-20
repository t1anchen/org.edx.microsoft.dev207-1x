// Learn more about F# at http://fsharp.org

open System

type person =
    { name: string
      age: int
      id: int }

let GetUser username userage =
    { name = username
      age = userage
      id = userage * username.Length }

[<EntryPoint>]
let main argv =
    Console.WriteLine("Enter the main users name: ")
    let name = Console.ReadLine()
    Console.WriteLine("Enter the main users age: ")
    let age = Console.ReadLine()
    let mainuser = GetUser name (int age)

    let people =
            [ let mutable run = true
              while run do
                  Console.WriteLine("Do you want to add more people (y/n)? ")
                  if Console.ReadLine().ToLower() = "y" then
                      Console.WriteLine("Enter the users name: ")
                      let name = Console.ReadLine()
                      Console.WriteLine("Enter the users age: ")
                      let age = Console.ReadLine()
                      yield GetUser name (int age)
                  else run <- false ]

    let sameid =
        seq {
            for x in people do
                if x.id = mainuser.id then yield x
        }

    for x in sameid do
        Console.WriteLine(x.name)

    0 // return an integer exit code

// Result:
// Enter the main users name: 
// Brain
// Enter the main users age: 
// 4036
// Do you want to add more people (y/n)? 
// y
// Enter the users name: 
// Dave
// Enter the users age: 
// 5045
// Do you want to add more people (y/n)? 
// y
// Enter the users name: 
// Richard
// Enter the users age: 
// 7082
// Do you want to add more people (y/n)? 
// n
// Dave