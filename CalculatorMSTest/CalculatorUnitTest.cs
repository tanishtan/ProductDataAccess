using ProductDataAccess;

namespace CalculatorMSTest
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void TestForAddMethod()
        {
            //Arrange 
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 20;   
            int expectedResult = input1 + input2;

            int actualResult = 0;

            //Act
            actualResult = calc.Add(input1, input2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestForMinusMethod()
        {
            //Arrange 
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 20;
            int expectedResult = input1 - input2;

            int actualResult = 0;

            //Act
            actualResult = calc.Minus(input1, input2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestForDivideMethod()
        {
            //Arrange 
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 20;
            int expectedResult = input1 / input2;

            int actualResult = 0;

            //Act
            actualResult = calc.Divide(input1, input2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestForMultiplyMethod()
        {
            //Arrange 
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 20;
            int expectedResult = input1 * input2;

            int actualResult = 0;

            //Act
            actualResult = calc.Multiply(input1, input2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //[Ignore]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestForDivideWithZeroDenominatorThrowsException()
        {
            Calculator calc = new Calculator();
            int input1 = 50, input2 = 0;
            int expectedResult = 0;
            int actualResult = 0;
            actualResult = calc.Divide(input1, input2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestForDivideWithZeroDenominator()
        {
            Calculator calc = new Calculator();
            int input1 = 50, input2  = 0;
            int expectedResult = 0;
            int actualResult = 0;
            actualResult = calc.Divide(input1, input2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCalculateForPlusOperator()
        {
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 10;
            int expectedResult = input1 + input2;

            int actualResult = calc.Calculate("+", input1, input2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCalculateForMinusOperator()
        {
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 10;
            int expectedResult = input1 - input2;

            int actualResult = calc.Calculate("-", input1, input2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCalculateForDivideOperator()
        {
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 10;
            int expectedResult = input1 / input2;

            int actualResult = calc.Calculate("/", input1, input2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCalculateForMultiplyOperator()
        {
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 10;
            int expectedResult = input1 * input2;

            int actualResult = calc.Calculate("*", input1, input2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Ignore]
        [TestMethod]
        public void TestCalculateForDivideOperatorWithValidDenominator()
        {
            //Assert.Inconclusive();

        }

        [TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void TestCalculateForDivideOperatorWithInValidDenominator()
        {
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 0;
            int expectedResult = 0;

            int actualResult = calc.Calculate("/", input1, input2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCalculateForModulusOperator()
        {
        Calculator calc = new Calculator();
        int input1 = 10, input2 = 10;
        int expectedResult = input1 % input2;

        int actualResult = calc.Calculate("%", input1, input2);

        Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCalculateForInvalidOperator()
        {
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 10;
            int expectedResult = -1;

            int actualResult = calc.Calculate("==", input1, input2);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestCalculateForModulusOperatorZeroDenominator()
        {
            Calculator calc = new Calculator();
            int input1 = 10, input2 = 0;
            int expectedResult = 0;

            int actualResult = calc.Calculate("%", input1, input2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}