using System;
using SumAllNumbers;
using Xunit;
using FluentAssertions;

namespace tests
{
    public class SumAllTests
    {
        [Theory]
        [InlineData(1, 4, 10)]
        [InlineData(4, 1, 10)]
        [InlineData(5, 10, 45)]
        [InlineData(10, 5, 45)]
        [InlineData(5, 5, 10)]
        [InlineData(-5, 5, 0)]
        public void Given_two_numbers_should_return_the_sum_of_those_and_all_inbetween(int first, int second, int expected)
        {
            // Act
            var result = Program.SumAll(first, second);

            // Assert
            result.Should().Be(expected);
        }
    }
}
