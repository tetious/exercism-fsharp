module LuciansLusciousLasagna

let expectedMinutesInOven = 40

let remainingMinutesInOven actual = expectedMinutesInOven - actual

let preparationTimeInMinutes layers = layers * 2

let elapsedTimeInMinutes layers inOven =
    preparationTimeInMinutes layers + inOven
