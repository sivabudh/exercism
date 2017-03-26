module LeapYear


let isLeapYear year =
    (* 
        Note: the order of pattern matching *matters*
    *)
    match year with
    | year when year % 400 = 0 -> true
    | year when year % 100 = 0 -> false
    | year when year % 4 = 0 -> true
    | _ -> false