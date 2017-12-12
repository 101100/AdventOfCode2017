namespace AdventOfCode2017.FSharp


module Day1 =
    let sumTuple (a, b) = a + b
    
    let toDigits input =
        Seq.map
            (string >> int)
            input

    let part1 (input: string) =
        input
        |> toDigits
        |> Seq.fold
            (fun (sum, last) next ->
                if last = next then (sum + next, next)
                else (sum, next))
            (0, -1)
        |> sumTuple
        
    let makeHalfSeq input =
        let halfCount = (Seq.length input) / 2
        let leftHalf = Seq.take halfCount input
        let rightHalf = Seq.take halfCount (Seq.skip halfCount input)

        Seq.zip leftHalf rightHalf

    let part2 (input: string) =
        input
        |> toDigits
        |> makeHalfSeq
        |> Seq.fold
            (fun sum (left, right) ->
                if left = right then sum + left
                else sum)
            0
        |> (*) 2
