using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lab1
{
    [TestClass]
    public class Task1Tests
    {
        [TestMethod]
        public void GetCubeEdge_PositiveVolume_ReturnsCorrectEdge()
        {
            double volume = 27.0;
            double expectedEdge = 3.0;
            double actualEdge = Task1.GetCubeEdge(volume);
            Assert.AreEqual(expectedEdge, actualEdge, 0.0001);
        }

        [TestMethod]
        public void GetCubeEdge_ZeroVolume_ReturnsZero()
        {
            double volume = 0.0;
            double expectedEdge = 0.0;
            double actualEdge = Task1.GetCubeEdge(volume);
            Assert.AreEqual(expectedEdge, actualEdge, 0.0001);
        }

        [TestMethod]
        public void GetCubeEdge_FractionalVolume_ReturnsCorrectEdge()
        {
            double volume = 15.625; 
            double expectedEdge = 2.5;
            double actualEdge = Task1.GetCubeEdge(volume);
            Assert.AreEqual(expectedEdge, actualEdge, 0.0001);
        }
    }
}
