package sum_all

import "testing"

type testpairs struct {
	values []int
	sum    int
}

var tests = []testpairs{
	{[]int{1, 4}, 10},
	{[]int{4, 1}, 10},
	{[]int{5, 5}, 10},
	{[]int{5, 10}, 45},
	{[]int{10, 5}, 45},
	{[]int{-5, 5}, 0},
}

func TestSumAll(t *testing.T) {
	for _, test := range tests {
		s := sumAll(test.values[0], test.values[1])
		if s != test.sum {
			t.Error(
				"For", test.values,
				"expected", test.sum,
				"got", s,
			)
		}
	}
}
