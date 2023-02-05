module PizzaPricing

type Pizza =
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza) : int =
    match pizza with
    | ExtraSauce p -> pizzaPrice p + 1
    | ExtraToppings p -> pizzaPrice p + 2
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10

let orderPrice (pizzas: Pizza list) : int =
    let basePrice = pizzas |> List.sumBy pizzaPrice

    match pizzas.Length with
    | 1 -> basePrice + 3
    | 2 -> basePrice + 2
    | _ -> basePrice
