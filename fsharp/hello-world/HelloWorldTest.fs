module HelloWorldTest

open Xunit

open HelloWorld

[<Fact>]
let SayHi() =
    Assert.Equal(hello, "Hello, World!")