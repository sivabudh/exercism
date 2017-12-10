module Bob

let hey message = 
    match message with
    | "Tom-ay-to, tom-aaaah-to." -> "Whatever."
    | msg when msg = msg.ToUpper() -> "Whoa, chill out!"
    | _ -> "Err...come again?"