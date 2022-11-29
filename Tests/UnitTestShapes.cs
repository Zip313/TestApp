using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using TestLibraryShapes;

namespace Tests
{
    [TestClass]
    public class UnitTestShapes
    {        
        [TestMethod]
        public void TestGetSquareRectBySides()
        {
            Assert.AreEqual(Shapes.GetSquare(2, 3, 3.605551275463989d), 3.000000000000001d);
        }
        
        
        [TestMethod]
        public void TestGetSquareRectByPoints()
        {
            Assert.AreEqual(Shapes.GetSquare(new Point(1,1), new Point(1, -1), new Point(-2, -1)), 3.000000000000001d);
        }
        
        
        [TestMethod]
        public void TestGetSquareRectByAll()
        {
            Assert.AreEqual(Shapes.GetSquare(new Point(1, 1), new Point(1, -1), new Point(-2, -1)), Shapes.GetSquare(2, 3, 3.605551275463989d));
        }
        
        
        [TestMethod]
        public void TestGetSquareCircleByRadius()
        {
            Assert.AreEqual(Shapes.GetSquare(4), 50.26548245743669d);
        }

        [TestMethod]
        public void TestRectIsRightByPoints()
        {
            Assert.IsFalse(Shapes.IsRectRight(new Point(1, 1), new Point(1, -1), new Point(-2, -1)));
        }

        [TestMethod]
        public void TestRectIsRightBySides()
        {
            Assert.IsTrue(Shapes.IsRectRight(3,3,3));
        }




    }
}
