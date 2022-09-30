using Moq;

namespace AdaCalculator.Tests
{
    public class CalculatorMachinesTests
    {

        [Fact]
        public void Calculate_SumTwoNumbers_ReturnCorrectValueAndOperation()
        {
            // Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("sum", 8));
            CalculatorMachine calcMach = new CalculatorMachine(mock.Object);

            // Act
            (string operation, double result) op = calcMach.Calculate("sum", 6.2, 1.8);

            // Assert
            mock.Verify(x => x.Calculate("sum", 6.2, 1.8), Times.Once);
        }
    }
}
