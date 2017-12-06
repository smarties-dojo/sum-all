package sum_all

func sumAll(a int, b int) int {
	if a == b {
		return 2 * a
	}

	if a > b {
		return sumAll(b, a)
	}

	sum := 0
	for i := a; i <= b; i++ {
		sum += i
	}

	return sum
}
