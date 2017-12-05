namespace SumAllNumbers

module Library =
    let SumAll first second =
        let step = if first < second then 1 else -1
        [first..step..second]
        |> List.sum
