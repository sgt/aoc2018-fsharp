module Aoc2018.Util

open FSharpPlus

let readInts =
    String.split [ "\n"; "\r" ]
    >> filter (fun x -> x <> "")
    >> map int

let repeat xs =
    seq {
        while true do
            yield! xs
    }
