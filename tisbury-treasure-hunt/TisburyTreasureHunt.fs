module TisburyTreasureHunt

let getCoordinate (_, coord) : string = coord

let convertCoordinate (coordinate: string) : int * char =
    let c = coordinate |> Seq.toArray
    (c[0] |> string |> int, c[1])

let compareRecords (_, coord1) (_, coord2, _) : bool = coord2 = convertCoordinate coord1

let createRecord (treasure, coord1) (location, coord2, quadrant) : (string * string * string * string) =
    if coord2 = convertCoordinate coord1 then
        (coord1, location, quadrant, treasure)
    else
        ("", "", "", "")
