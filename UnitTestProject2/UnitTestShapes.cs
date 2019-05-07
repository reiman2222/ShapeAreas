using Microsoft.VisualStudio.TestTools.UnitTesting;

using ShapeAreasTerminalProgram;

namespace UnitTestProject
{
    [TestClass]
    public class TestShapeAreas
    {
        [TestMethod]
        public void TestSquare()
        {
            Square s = new Square(2);
            Assert.AreEqual(4, s.Area());
        }

        [TestMethod]
        public void TestRectangle()
        {
            Rectangle r = new Rectangle(2, 3);
            Assert.AreEqual(6, r.Area());
        }

        [TestMethod]
        public void TestTriangle()
        {
            Triangle t = new Triangle(4, 5);
            Assert.AreEqual(10, t.Area());
        }

        [TestMethod]
        public void TestHexagon()
        {
            Hexagon h = new Hexagon(6);
            Assert.AreEqual(93.53, System.Math.Round(h.Area(), 2));

        }
    }
}
