using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab1
{
    [TestClass]
    public class Task5Tests
    {
        [TestMethod]
        public void SquareOfSum_PositiveNumbers_CalculatesCorrectly()
        {
           
            Assert.AreEqual(25, Task5.SquareOfSum(2, 3));
        }

        [TestMethod]
        public void SquareOfSum_NegativeNumbers_CalculatesCorrectly()
        {
     
            Assert.AreEqual(81, Task5.SquareOfSum(-4, -5));
        }

        [TestMethod]
        public void SquareOfSum_MixedNumbers_CalculatesCorrectly()
        {
           
            Assert.AreEqual(9, Task5.SquareOfSum(-2, 5));
            
          
            Assert.AreEqual(0, Task5.SquareOfSum(5, -5));
        }

        [TestMethod]
        public void SquareOfSum_Zeros_ReturnsZero()
        {
            
            Assert.AreEqual(0, Task5.SquareOfSum(0, 0));
        }
    }
}
