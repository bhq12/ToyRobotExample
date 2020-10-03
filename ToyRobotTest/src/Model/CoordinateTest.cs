using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotExample.src.Model;

namespace ToyRobotTest
{
    [TestClass]
    public class CoordinateTest
    {

        [TestMethod]
        public void EqualsZeroCoordinates() {
            var coordinate1 = new Coordinate(0, 0);
            var coordinate2 = new Coordinate(0, 0);

            Assert.AreEqual(coordinate1, coordinate2);
        }

        [TestMethod]
        public void EqualsNonZeroCoordinates() {
            var coordinate1 = new Coordinate(1, 1);
            var coordinate2 = new Coordinate(1, 1);

            Assert.AreEqual(coordinate1, coordinate2);
        }

        [TestMethod]
        public void NotEqualsNotCoordinate() {
            var coordinate1 = new Coordinate(0, 0);
            var coordinate2 = 1;

            Assert.AreNotEqual(coordinate1, coordinate2);
        }


        [TestMethod]
        public void NotEqualsZeroAndNonZeroCoordinates() {
            var coordinate1 = new Coordinate(0, 0);
            var coordinate2 = new Coordinate(1, 1);

            Assert.AreNotEqual(coordinate1, coordinate2);
        }

        [TestMethod]
        public void NotEqualsNonZeroAndZeroCoordinates() {
            var coordinate1 = new Coordinate(1, 1);
            var coordinate2 = new Coordinate(0, 0);

            Assert.AreNotEqual(coordinate1, coordinate2);
        }

        [TestMethod]
        public void NotEqualsNonZeroCoordinates() {
            var coordinate1 = new Coordinate(1, 1);
            var coordinate2 = new Coordinate(2, 2);

            Assert.AreNotEqual(coordinate1, coordinate2);
        }

        [TestMethod]
        public void NotEqualsNonZeroCoordinatesYDifferent() {
            var coordinate1 = new Coordinate(1, 1);
            var coordinate2 = new Coordinate(1, 2);

            Assert.AreNotEqual(coordinate1, coordinate2);
        }

        [TestMethod]
        public void NotEqualsNonZeroCoordinatesXDifferent() {
            var coordinate1 = new Coordinate(1, 1);
            var coordinate2 = new Coordinate(2, 1);

            Assert.AreNotEqual(coordinate1, coordinate2);
        }
    }
}
