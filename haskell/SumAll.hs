module SumAll where

sumall :: Integral a => a -> a -> a
sumall first second
    | first == second = first + second
    | first < second = sum [first .. second]
    | otherwise = sum [second .. first]