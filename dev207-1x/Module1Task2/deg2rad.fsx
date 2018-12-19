open System

let deg2rad (deg : float) = deg * Math.PI /  180.0
let rad2deg (rad : float) = rad * 180.0 / Math.PI

let testa = deg2rad 180.0
let testb = rad2deg testa

deg2rad 67.0;;

// Result
// deg2rad 67.0;;
//  val it : float = 1.169370599