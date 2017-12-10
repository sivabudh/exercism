module BobFact

open Xunit
open Bob
    
[<Fact>]
let ``Stating something`` () =
    Assert.Equal(hey "Tom-ay-to, tom-aaaah-to.", "Whatever.")

[<Fact>]
let ``Shouting`` () =
    Assert.Equal("Whoa, chill out!", hey "WATCH OUT!")

[<Fact (Skip = "Remove to run Fact")>]
let ``Asking a question`` () =
    Assert.Equal(hey "Does this cryogenic chamber make me look fat?", "Sure.")

[<Fact (Skip = "Remove to run Fact")>]
let ``Asking a numeric question`` () =
    Assert.Equal(hey "You are, what, like 15?", "Sure.")

[<Fact>]
let ``Forceful questions`` () =
    Assert.Equal(hey "WHAT THE HELL WERE YOU THINKING?", "Whoa, chill out!")

[<Fact>]
let ``Shouting numbers`` () =
    Assert.Equal(hey "1, 2, 3 GO!", "Whoa, chill out!")

[<Fact (Skip = "Remove to run Fact")>]
let ``Only numbers`` () =
    Assert.Equal(hey "1, 2, 3", "Whatever.")

[<Fact (Skip = "Remove to run Fact")>]
let ``Question only with numbers`` () =
    Assert.Equal(hey "4?", "Sure.")

[<Fact>]
let ``Shouting with special characters`` () =
    Assert.Equal(hey "ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!", "Whoa, chill out!")

[<Fact>]
let ``Shouting with no exlamation mark`` () =
    Assert.Equal(hey "I HATE YOU", "Whoa, chill out!")

[<Fact (Skip = "Remove to run Fact")>]
let ``Statement containing question mark`` () =
    Assert.Equal(hey "Ending with ? means a question.", "Whatever.")

[<Fact (Skip = "Remove to run Fact")>]
let ``Prattling on`` () =
    Assert.Equal(hey "Wait! Hang on. Are you going to be OK?", "Sure.")

[<Fact (Skip = "Remove to run Fact")>]
let ``Silence`` () =
    Assert.Equal(hey "", "Fine. Be that way!")

[<Fact (Skip = "Remove to run Fact")>]
let ``Prolonged silence`` () =
    Assert.Equal(hey "    ", "Fine. Be that way!")

[<Fact (Skip = "Remove to run Fact")>]
let ``Multiple line question`` () =
    Assert.Equal(hey "Does this cryogenic chamber make me look fat?\nno", "Whatever.")