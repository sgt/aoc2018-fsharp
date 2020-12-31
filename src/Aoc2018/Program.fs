open System
open System.IO

open Aoc2018

let solvers =
    Map.ofList [ (("1", "A"), Day1.solveA)
                 (("1", "B"), Day1.solveB) ]

let from = sprintf "from %s"

let dataFilename = sprintf "data/day%s.txt"

let runSolution (day: string) (part: string) =
    match Map.tryFind (day, part) solvers with
    | Some (solver) -> dataFilename day |> File.ReadAllText |> solver
    | None -> "solver not found"

[<EntryPoint>]
let main argv =
    match argv with
    | [| day; part |] ->
        printfn "%s" (runSolution day (String.map Char.ToUpper part))
        0
    | _ ->
        printfn "invalid arguments"
        1
