using Moq;

namespace AdaCalculator.Tests
{
    public class CalculatorTestsMock
    {

        [Fact]
        public void Calculate_SumTwoNumbers_ReturnCorrectValueAndOperation()
        {
            // Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("sum", 7.7));
            CalculatorMachine calcMach = new CalculatorMachine(mock.Object);



            // Act
            (string operation, double result) op = calcMach.Calculate("sum", 10, 3.2);
            // Assert
            Assert.Equal("sum", op.operation);
            Assert.Equal(7.7, op.result);
        }

        [Fact]
        public void Calculate_SubtractTwoNumbers_ReturnCorrectValueAndOperation()
        {
            // Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("subtract", 1.3));
            CalculatorMachine calcMach = new CalculatorMachine(mock.Object);
            // Act
            (string operation, double result) op = calcMach.Calculate("sum", 4.5, 3.2);
            // Assert
            Assert.Equal("subtract", op.operation);
            Assert.Equal(1.3, op.result);
        }

        [Fact]
        public void Calculate_MultiplyTwoNumbers_ReturnCorrectValueAndOperation()
        {
            // Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("multiply", 1.3));
            CalculatorMachine calcMach = new CalculatorMachine(mock.Object);
            // Act
            (string operation, double result) op = calcMach.Calculate("multiply", 4.5, 3.2);
            // Assert
            Assert.Equal("multiply", op.operation);
            Assert.Equal(1.3, op.result);
        }

        [Fact]
        public void Calculate_DivideTwoNumbers_ReturnCorrectValueAndOperation()
        {
            // Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("divide", 1.4));
            CalculatorMachine calcMach = new CalculatorMachine(mock.Object);
            // Act
            (string operation, double result) op = calcMach.Calculate("sum", 4.5, 3.2);
            // Assert
            Assert.Equal("divide", op.operation);
            Assert.Equal(1.40, op.result);
        }
    }
}
