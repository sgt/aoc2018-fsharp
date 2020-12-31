module Aoc2018.Day1

open Util
open FSharpPlus

let solveA = readInts >> sum >> string

let solveB =
    readInts
    >> repeat
    >> Seq.scan (fun (mem, freq) x -> Set.add freq mem, freq + x) (Set.empty, 0)
    >> Seq.find (fun (mem, freq) -> Set.contains freq mem)
    >> snd
    >> string
