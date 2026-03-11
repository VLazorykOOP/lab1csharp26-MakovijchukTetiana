using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lab1
{
    [TestClass]
    public class Task4Tests
    {
        [TestMethod]
        public void GetUnknownDate_ValidPositiveDays_ReturnsCorrectDate()
        {
            // Arrange
            int days = 10;
            // Очікувана дата: сьогодні мінус 10 днів
            DateTime expectedDate = DateTime.Today.AddDays(-10);

            // Act
            DateTime actualDate = Task4.GetUnknownDate(days);

            // Assert
            Assert.AreEqual(expectedDate, actualDate, "Дата обчислена неправильно.");
        }

        [TestMethod]
        public void GetUnknownDate_ZeroDays_ThrowsException()
        {
            try
            {
                // Перевіряємо, чи буде помилка при n = 0
                Task4.GetUnknownDate(0);
                Assert.Fail("Очікувалася помилка ArgumentException, бо кількість днів має бути > 0.");
            }
            catch (ArgumentException)
            {
                // Якщо зловили помилку - тест успішний!
            }
        }

        [TestMethod]
        public void GetUnknownDate_NegativeDays_ThrowsException()
        {
            try
            {
                // Перевіряємо від'ємні значення
                Task4.GetUnknownDate(-5);
                Assert.Fail("Очікувалася помилка ArgumentException для від'ємних значень.");
            }
            catch (ArgumentException)
            {
                // Якщо зловили помилку - тест успішний!
            }
        }
    }
}
