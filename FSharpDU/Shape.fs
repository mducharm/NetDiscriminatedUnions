module Shape

open System

type Shape =
    | Circle of float
    | Rectangle of float * float
    | Square of float
    | Triangle of float * float

let calculateArea =
    function
    | Circle c -> c * Math.PI
    | Rectangle (b, h) -> b * h
    | Square (s) -> s * s
    | Triangle (b, h) -> b * h * 0.5