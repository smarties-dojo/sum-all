module Tests

open System
open Xunit
open SumAllNumbers

[<Theory>]
[<InlineData(4, 1, 10)>]
[<InlineData(1, 4, 10)>]
[<InlineData(5, 10, 45)>]
[<InlineData(10, 5, 45)>]
[<InlineData(-5, 5, 0)>]
[<InlineData(5, 5, 10)>]
let ``Given two numbers should return the sum of those and all inbetween`` (first, second, expected) =
    // Act
    let result = Library.SumAll first second

    // Assert
    Assert.Equal(result, expected)
