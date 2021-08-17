using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class MultiParameterTests
    {
        [TestMethod]
        public void AddMultipleIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            int actual = calculator.Add(100, 200, 300, 400, 500, 600);

            var expected = 2100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMultipleDoubles()
        {
            MyCalculator calculator = new MyCalculator();

            double actual = calculator.Add(10.3D, 20.2D, 30.1D, 50.0D, 1.2D);

            var expected = 111.8D;

            Assert.AreEqual(expected, actual);  
        }

        [TestMethod]
        public void AddMultipleLongs()
        {
            MyCalculator calculator = new MyCalculator();

            long actual = calculator.Add(1L, 2L, 3L, 4L, 5L, 10000000000L);

            var expected = 10000000015L;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyMultipleIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            int actual = calculator.Multiply(10, 20, 30, 40);

            var expected = 240000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyMultipleDoubles()
        {
            MyCalculator calculator = new MyCalculator();

            double actual = calculator.Multiply(10D, 20D, 30D, 40D);

            var expected = 240000D;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MultiplyMultipleLongs()
        {
            MyCalculator calculator = new MyCalculator();

            long actual = calculator.Multiply(10L, 20L, 30L, 40L);

            var expected = 240000L;

            Assert.AreEqual(expected, actual);
        }
    }
}
