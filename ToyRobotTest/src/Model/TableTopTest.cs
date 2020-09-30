using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotExample.src.Model;

namespace ToyRobotTest
{
    [TestClass]
    public class TableTopTest
    {
                
        [TestMethod]
        public void IsValidPlaceTestZeroSizeTableTopZeroCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, 0));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestZeroSizeTableTopNonZeroXCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(1, 0));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestZeroSizeTableTopNonZeroYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, 1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestZeroSizeTableTopNonZeroXYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(1, 1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestZeroSizeTableTopNegativeXCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(-1, 0));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestZeroSizeTableTopNegativeYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, -1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestZeroSizeTableTopNegativeXYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(-1, -1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeOneTableTopZeroCoordinate()
        {
            var zeroSizeTableTop = new TableTop(1, 1);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, 0));

            Assert.AreEqual(true, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeOneTableTopNonZeroXCoordinate()
        {
            var zeroSizeTableTop = new TableTop(1, 1);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(1, 0));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeOneTableTopNonZeroYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, 1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeOneTableTopNonZeroXYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(1, 1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeOneTableTopNegativeXCoordinate()
        {
            var zeroSizeTableTop = new TableTop(1, 1);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(-1, 0));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeOneTableTopNegativeYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, -1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeOneTableTopNegativeXYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(0, 0);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(-1, -1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableTopZeroXYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, 0));

            Assert.AreEqual(true, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNonZeroXCoordinateInsideBoundary()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(3, 0));

            Assert.AreEqual(true, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNegativeXCoordinate()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(-1, 0));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNonZeroXCoordinateAtBoundary()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(4, 0));

            Assert.AreEqual(true, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNonZeroXCoordinateAtBoundaryPlusOne()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(5, 0));

            Assert.AreEqual(false, isValidPlace);
        }
        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNonZeroYCoordinateInsideBoundary()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, 3));

            Assert.AreEqual(true, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNegativeYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, -1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNonZeroYCoordinateAtBoundary()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, 4));

            Assert.AreEqual(true, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNonZeroYCoordinateAtBoundaryPlusOne()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(0, 5));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableNegativeXYCoordinate()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(-1, -1));

            Assert.AreEqual(false, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableXYCoordinateBothInRange()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(2, 2));

            Assert.AreEqual(true, isValidPlace);
        }

        [TestMethod]
        public void IsValidPlaceTestSizeFiveTableXYCoordinateBothOutOFRange()
        {
            var zeroSizeTableTop = new TableTop(5, 5);

            var isValidPlace = zeroSizeTableTop.IsValidPlace(new Coordinate(20, 20));

            Assert.AreEqual(false, isValidPlace);
        }
    }
}
