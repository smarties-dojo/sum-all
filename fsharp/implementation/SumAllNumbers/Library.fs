namespace SumAllNumbers

module Library =
    let SumAll first second =
        let step = if first < second then 1 else -1
        let allNumbers = 
            if first = second 
                then [first; second] 
                else [first..step..second]
        
        allNumbers
        |> List.sum