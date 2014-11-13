using System;
using System.Threading;
using FSLCodeExercise.Core.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSLCodeExercise.UnitTest
{
    [TestClass]
    public class ShapeManagerUnitTest
    {
        [TestMethod]
        public void SquareShape()
        {
            var area1 = ShapeManager.Instance.Area(1, 10);
            Assert.AreEqual(100, area1, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void CircleShape()
        {
            var area2 = ShapeManager.Instance.Area(2, 10);
            Assert.AreEqual(100, area2, 78.539816339744831, "Account not debited correctly");
        }

        [TestMethod]
        public void TriangleShape()
        {
            var area3 = ShapeManager.Instance.Area(3, 10);
            Assert.AreEqual(100, area3, 66.666666666666657, "Account not debited correctly");
        }

    }
}
