using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lab1
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void IsSumOfDigitsOdd_OddSum_ReturnsTrue()
        {
            
            bool actualResult = Task2.IsSumOfDigitsOdd(23);
            
            // Assert
            Assert.IsTrue(actualResult, "Сума цифр 2 і 3 є непарною, має повернути true.");
        }

        [TestMethod]
        public void IsSumOfDigitsOdd_EvenSum_ReturnsFalse()
        {
            // Arrange & Act (2 + 2 = 4, це парне число)
            bool actualResult = Task2.IsSumOfDigitsOdd(22);
            
            // Assert
            Assert.IsFalse(actualResult, "Сума цифр 2 і 2 є парною, має повернути false.");
        }

        [TestMethod]
        public void IsSumOfDigitsOdd_NegativeNumber_WorksCorrectly()
        {
            // Arrange & Act (|-45| -> 4 + 5 = 9, це непарне)
            bool actualResult = Task2.IsSumOfDigitsOdd(-45);
            
            // Assert
            Assert.IsTrue(actualResult, "Для від'ємних чисел функція має брати модуль.");
        }

        [TestMethod]
        public void IsSumOfDigitsOdd_NotTwoDigitNumber_ThrowsException()
        {
            try
            {
                // Намагаємося передати неправильне число (одноцифрове)
                Task2.IsSumOfDigitsOdd(5);
                
                // Якщо код не зупинився на помилці і дійшов сюди — тест провалено
                Assert.Fail("Очікувалася помилка ArgumentException, але програма її не викинула.");
            }
            catch (ArgumentException)
            {
                // Якщо ми зловили ArgumentException — наша функція працює правильно!
                // Тест пройдено успішно.
            }
        }
    }
}
    
