module CollatzConjecture

let steps (number: int) : int option =
    let rec calc n = 
        if n = 1 then 0
        elif n % 2 = 0 then 1 + calc (n / 2) 
        else 1 + calc (n * 3 + 1)

    if number < 1 then None else Some (calc number)
