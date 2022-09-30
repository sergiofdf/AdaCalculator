using FluentAssertions;

namespace AdaCalculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [ClassData(typeof(TupleDataSum1))]
        [ClassData(typeof(TupleDataSum2))]
        [ClassData(typeof(TupleDataSum3))]
        [ClassData(typeof(TupleDataSubtract1))]
        [ClassData(typeof(TupleDataSubtract2))]
        [ClassData(typeof(TupleDataSubtract3))]
        [ClassData(typeof(TupleDataMultiply1))]
        [ClassData(typeof(TupleDataMultiply2))]
        [ClassData(typeof(TupleDataMultiply3))]
        [ClassData(typeof(TupleDataDivide1))]
        [ClassData(typeof(TupleDataDivide2))]
        [ClassData(typeof(TupleDataDivide3))]
        public void Calculate_DifferentOperations_ShouldReturnCorrectResult(Tuple<string, double, double> input, Tuple<string, double> output)
        {
            var expected = output.ToValueTuple();
            var sut = new Calculator();

            var result = sut.Calculate(input.Item1, input.Item2, input.Item3);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Calculate_DivisionByZero_ShouldReturnInfinite()
        {
            var expected = ("divide", double.PositiveInfinity);
            var sut = new Calculator();

            var result = sut.Calculate("divide", 6, 0);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Calculate_DefaultOperation_ShouldReturnSumValueAndOperation()
        {
            var expected = ("sum", 5);
            var sut = new Calculator();

            var result = sut.Calculate("", 3, 2);

            result.Should().BeEquivalentTo(expected);
        }
    }
}