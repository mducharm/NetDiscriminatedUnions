module Shape

open System

type Shape =
    | Circle of radius: float
    | Rectangle of length: float * height: float
    | Square of side: float
    | Triangle of length: float * height: float

let calculateArea =
    function
    | Circle radius -> radius * Math.PI
    | Rectangle (length, height) -> length * height
    | Square side -> side * side
    | Triangle (length, height) -> length * height * 0.5