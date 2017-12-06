-- file Spec.hs
import Test.Hspec
import Test.QuickCheck
import SumAll

main :: IO ()
main = hspec $ do
  describe "sumall" $ do
    it "returns 10 when given 1 and 4" $ do
      sumall 1 4 `shouldBe` (10 :: Int)

    it "returns 45 when given 5 and 10" $ do
        sumall 5 10 `shouldBe` (45 :: Int)

    it "returns 0 when given -5 and 5" $ do
        sumall (-5) 5 `shouldBe` (0 :: Int)

    it "returns the same result with reversed arguments" $
      property $ \x y -> (sumall x y :: Int) == (sumall y x :: Int)