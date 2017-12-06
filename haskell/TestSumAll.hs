module TestSumAll where

import Test.HUnit
import SumAll

test1And4ShouldEqual10 :: Test
test1And4ShouldEqual10 =
    TestCase $ assertEqual "Given 1 and 4 should return 10"
                           10 (sumall 1 4)

test4And1ShouldEqual10 :: Test
test4And1ShouldEqual10 =
    TestCase $ assertEqual "Given 4 and 1 should return 10"
                            10 (sumall 4 1)

test5And5ShouldEqual10 :: Test
test5And5ShouldEqual10 =
    TestCase $ assertEqual "Given 5 and 5 should return 10"
                            10 (sumall 5 5)

test5And10ShouldEqual45 :: Test
test5And10ShouldEqual45 =
    TestCase $ assertEqual "Given 5 and 10 should return 45"
                            45 (sumall 5 10)

test10And5ShouldEqual45 :: Test
test10And5ShouldEqual45 =
    TestCase $ assertEqual "Given 10 and 5 should return 45"
                            45 (sumall 10 5)

test5AndMinus5ShouldEqual0 :: Test
test5AndMinus5ShouldEqual0 =
    TestCase $ assertEqual "Given 5 and -5 should return 0"
                            0 (sumall 5 (-5))

main :: IO Counts
main = runTestTT $ TestList
    [ test1And4ShouldEqual10
    , test4And1ShouldEqual10
    , test5And5ShouldEqual10
    , test5And10ShouldEqual45
    , test10And5ShouldEqual45
    , test5AndMinus5ShouldEqual0
    ]