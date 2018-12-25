// Learn more about F# at http://fsharp.org

open System
open System.IO

// Calculations

type Gun = {
    Xcoord: float
    Ycoord: float
    Speed: float
    ExpectedDistance: float
    Name: string
}

let GRAVITY = 9.81

let angleOfReach (gravity: float, distance: float, speed: float) =
    0.5 * Math.Asin(gravity * distance / (speed * speed))

let distanceTravelled (speed: float, theta: float, gravity: float) =
    (speed * speed) * Math.Sin(2.0 * theta) / gravity

let angle (x: float, y: float) =
    atan(y/x)

// Utilities

let GetFile =
    Console.Write("Enter the full path to the name of the input file: ")
    Console.ReadLine()

[<EntryPoint>]
let main argv =
    try
        use input =
            new StreamReader(match argv.Length with
                             | 0 -> GetFile
                             | _ -> argv.[0])

        let entities =
            [ while not input.EndOfStream do
                let raw = input.ReadLine()
                let values = raw.Split(',')
                yield { Xcoord = float values.[0];
                    Ycoord = float values.[1];
                    Speed = float values.[2];
                    ExpectedDistance = float values.[3];
                    Name = values.[4] } ]

        entities
        |> Seq.iter(fun gun ->
            let theta = angle(gun.Xcoord, gun.Ycoord)
            let requiredAngle = angleOfReach(GRAVITY, gun.ExpectedDistance, gun.Speed)
            let dist = distanceTravelled(gun.Speed, theta, GRAVITY)
            printfn "%s theta:%f angle:%f dist:%f" gun.Name theta requiredAngle dist
        )

        let (|Hit|Miss|) input =
            match input with
                | { Gun.ExpectedDistance = expectedDistance; Gun.Speed = speed; } when
                    Double.IsNaN(angleOfReach(GRAVITY, expectedDistance, speed)) -> Hit
                | _ -> Miss

        printfn "Hit: %A" [for gun in entities ->
                                                match gun with
                                                | Hit -> Some(gun.Name)
                                                | _ -> None
        ]

        printfn "Miss: %A" [for gun in entities ->
                                                match gun with
                                                | Miss -> Some(gun.Name)
                                                | _ -> None
        ]

        0
    with
    | :? System.IO.FileNotFoundException ->
        Console.WriteLine("File Not Found.")
        -1
    | _ ->
        Console.WriteLine("Something else happened")
        -1
