module GuessingGame

let reply (guess: int) : string =
    match guess - 42 with
    | 0 -> "Correct"
    | g when abs g = 1 -> "So close"
    | g when g < 1 -> "Too low"
    | _ -> "Too high"
