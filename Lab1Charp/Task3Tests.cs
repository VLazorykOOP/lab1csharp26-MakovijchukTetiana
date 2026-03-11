using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab1
{
    [TestClass]
    public class Task3Tests
    {
        [TestMethod]
        public void GetPointLocation_InsideRegion_ReturnsTak()
        {
            // Точка (0, -50) знаходиться чітко посередині заштрихованого трикутника
            Assert.AreEqual("Так", Task3.GetPointLocation(0, -50));
            
            // Точка (40, -60) також всередині
            Assert.AreEqual("Так", Task3.GetPointLocation(40, -60));
        }

        [TestMethod]
        public void GetPointLocation_OnBorder_ReturnsNaMezhi()
        {
            // Початок координат (сама верхня вершина трикутника)
            Assert.AreEqual("На межі", Task3.GetPointLocation(0, 0));
            
            // Точка на бічній грані y = -|x|
            Assert.AreEqual("На межі", Task3.GetPointLocation(50, -50));
            Assert.AreEqual("На межі", Task3.GetPointLocation(-50, -50));

            // Точка на нижній грані y = -100
            Assert.AreEqual("На межі", Task3.GetPointLocation(0, -100));
        }

        [TestMethod]
        public void GetPointLocation_OutsideRegion_ReturnsNi()
        {
            // Точка вище осі X (у додатній площині)
            Assert.AreEqual("Ні", Task3.GetPointLocation(0, 50));
            
            // Точка нижче межі y = -100
            Assert.AreEqual("Ні", Task3.GetPointLocation(0, -101));
            
            // Точка збоку від трикутника (занадто великий x)
            Assert.AreEqual("Ні", Task3.GetPointLocation(100, -50));
        }
    }
}
