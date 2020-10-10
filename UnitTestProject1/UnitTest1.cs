using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionSubtraction;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Addition")]
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            Program program = new Program();
            int expected = 15;
            int numOne = 10;
            int numTwo = 5;
            //Act
            var actual = program.add(numOne, numTwo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory("Addition")]
        [TestMethod]
        public void TestAddition()
        {
            //Arrange
            Program regex = new Program();
            int expected = 15;
            int numOne = 10;
            int numTwo = 5;
            //Act
            var actual = regex.add(numOne, numTwo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory("Substraction")]
        [TestMethod]
        public void TestSub()
        {
            //Arrange
            Program regex = new Program();
            int expected = 5;
            int numOne = 10;
            int numTwo = 5;
            //Act
            var actual = regex.sub(numOne, numTwo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory("Substraction")]
        [TestMethod]
        public void TestSubtraction()
        {
            //Arrange
            Program regex = new Program();
            int expected = 5;
            int numOne = 10;
            int numTwo = 5;
            //Act
            var actual = regex.substraction(numOne, numTwo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
