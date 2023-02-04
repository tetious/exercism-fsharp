module Hamming

let distance (s1: string) (s2: string) : int option =
    match (s1, s2) with
    | (s1, s2) when s1 = s2 -> Some 0
    | (s1, s2) when s1.Length <> s2.Length -> None
    | pair -> pair ||> Seq.zip |> Seq.sumBy (fun (n1, n2) -> if n1 = n2 then 0 else 1) |> Some
