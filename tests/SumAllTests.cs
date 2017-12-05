using System;
using SumAllNumbers;
using Xunit;
using FluentAssertions;

namespace tests
{
    public class SumAllTests
    {
        [Fact]
        public void Given_1_and_4_should_return_10()
        {
            // Arrange
            var first = 1;
            var second = 4;

            // Act
            var result = Program.SumAll(first, second);

            // Assert
            result.Should().Be(10);
        }

        [Fact]
        public void Given_4_and_1_should_return_10()
        {
            // Arrange
            var first = 4;
            var second = 1;

            // Act
            var result = Program.SumAll(first, second);

            // Assert
            result.Should().Be(10);
        }

        [Fact]
        public void Given_5_and_10_should_return_45()
        {
            // Arrange
            var first = 5;
            var second = 10;

            // Act
            var result = Program.SumAll(first, second);

            // Assert
            result.Should().Be(45);
        }

        [Fact]
        public void Given_10_and_5_should_return_45()
        {
            // Arrange
            var first = 10;
            var second = 5;

            // Act
            var result = Program.SumAll(first, second);

            // Assert
            result.Should().Be(45);
        }

        [Fact]
        public void Given_5_and_5_should_return_10()
        {
            // Arrange
            var first = 5;
            var second = 5;

            // Act
            var result = Program.SumAll(first, second);

            // Assert
            result.Should().Be(10);
        }
    }
}
