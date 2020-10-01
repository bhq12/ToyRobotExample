using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotExample.src.Model;

namespace ToyRobotTest
{
    [TestClass]
    public class TableTopTest
    {
                
        [TestMethod]
        public void IsValidLocationTestZeroSizeTableTopZeroCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, 0));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestZeroSizeTableTopNonZeroXCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(1, 0));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestZeroSizeTableTopNonZeroYCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, 1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestZeroSizeTableTopNonZeroXYCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(1, 1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestZeroSizeTableTopNegativeXCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(-1, 0));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestZeroSizeTableTopNegativeYCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, -1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestZeroSizeTableTopNegativeXYCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(-1, -1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeOneTableTopZeroCoordinate() {
            var zeroSizeTableTop = new TableTop(1, 1);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, 0));

            Assert.AreEqual(true, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeOneTableTopNonZeroXCoordinate() {
            var zeroSizeTableTop = new TableTop(1, 1);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(1, 0));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeOneTableTopNonZeroYCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, 1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeOneTableTopNonZeroXYCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(1, 1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeOneTableTopNegativeXCoordinate() {
            var zeroSizeTableTop = new TableTop(1, 1);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(-1, 0));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeOneTableTopNegativeYCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, -1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeOneTableTopNegativeXYCoordinate() {
            var zeroSizeTableTop = new TableTop(0, 0);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(-1, -1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableTopZeroXYCoordinate() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, 0));

            Assert.AreEqual(true, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNonZeroXCoordinateInsideBoundary() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(3, 0));

            Assert.AreEqual(true, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNegativeXCoordinate() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(-1, 0));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNonZeroXCoordinateAtBoundary() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(4, 0));

            Assert.AreEqual(true, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNonZeroXCoordinateAtBoundaryPlusOne() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(5, 0));

            Assert.AreEqual(false, IsValidLocation);
        }
        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNonZeroYCoordinateInsideBoundary() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, 3));

            Assert.AreEqual(true, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNegativeYCoordinate() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, -1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNonZeroYCoordinateAtBoundary() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, 4));

            Assert.AreEqual(true, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNonZeroYCoordinateAtBoundaryPlusOne() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(0, 5));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableNegativeXYCoordinate() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(-1, -1));

            Assert.AreEqual(false, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableXYCoordinateBothInRange() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(2, 2));

            Assert.AreEqual(true, IsValidLocation);
        }

        [TestMethod]
        public void IsValidLocationTestSizeFiveTableXYCoordinateBothOutOFRange() {
            var zeroSizeTableTop = new TableTop(5, 5);

            var IsValidLocation = zeroSizeTableTop.IsValidLocation(new Coordinate(20, 20));

            Assert.AreEqual(false, IsValidLocation);
        }
    }
}
