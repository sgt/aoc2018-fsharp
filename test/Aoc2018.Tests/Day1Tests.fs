module Aoc2018.Tests.Day1Tests

open Aoc2018

open System
open Xunit

let testData1 =
    String.concat "\n" [ "+1"; "-2"; "+3"; "+1" ]

let testData2 =
    String.concat "\n" [ "+3"; "+3"; "+4"; "-2"; "-4" ]

let testData3 =
    String.concat "\n" [ "+7"; "+7"; "-2"; "-7"; "-4" ]

[<Fact>]
let ``solution A`` () = Assert.Equal("3", Day1.solveA testData1)

[<Fact>]
let ``solution B 1`` () = Assert.Equal("2", Day1.solveB testData1)

[<Fact>]
let ``solution B 2`` () =
    Assert.Equal("10", Day1.solveB testData2)

[<Fact>]
let ``solution B 3`` () =
    Assert.Equal("14", Day1.solveB testData3)
