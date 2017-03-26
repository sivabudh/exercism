module LeapTest

open Xunit

open LeapYear
    

[<Fact>]
let ``Is 1996 a valid leap year`` () = 
    Assert.Equal(isLeapYear 1996, true)
    
[<Fact>]
let ``Is 1997 an invalid leap year`` () = 
    Assert.Equal(isLeapYear 1997, false)
    
[<Fact>]
let ``Is the turn of the 20th century an invalid leap year`` () = 
    Assert.Equal(isLeapYear 1900, false)
    
[<Fact>]
let ``Is the turn of the 25th century a valid leap year`` () = 
    Assert.Equal(isLeapYear 2400, true)