using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotExample.src.Model;

namespace ToyRobotTest
{
    [TestClass]
    public class ToyRobotTest
    {
                
        [TestMethod]
        public void PlaceAtLocationSetsExpectedValues() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            Assert.AreEqual(true, toyRobot.IsPlaced);
            Assert.AreEqual(space, toyRobot.CurrentSpace);
            Assert.AreEqual(location, toyRobot.CurrentLocation);
            Assert.AreEqual(heading, toyRobot.CurrentHeading);

        }

        [TestMethod]
        public void UnPlaceResetsLocation() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            toyRobot.UnPlace();

            Assert.AreEqual(false, toyRobot.IsPlaced);
            Assert.AreEqual(null, toyRobot.CurrentSpace);
            Assert.AreEqual(null, toyRobot.CurrentLocation);
            Assert.AreEqual(null, toyRobot.CurrentHeading);

        }

        [TestMethod]
        public void RotateDoesNothingWhenUnplacedClockwise() {
            var toyRobot = new ToyRobot();

            toyRobot.Rotate(true);

            Assert.AreEqual(null, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateDoesNothingWhenUnplacedAntiClockwise() {
            var toyRobot = new ToyRobot();

            toyRobot.Rotate(false);

            Assert.AreEqual(null, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateClockwiseFromNorth() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Rotate(true);

            Assert.AreEqual(Heading.EAST, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateClockwiseFromEast() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.EAST;

            toyRobot.Place(location, space, heading);

            toyRobot.Rotate(true);

            Assert.AreEqual(Heading.SOUTH, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateClockwiseFromSouth() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.SOUTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Rotate(true);

            Assert.AreEqual(Heading.WEST, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateClockwiseFromWest() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.WEST;

            toyRobot.Place(location, space, heading);

            toyRobot.Rotate(true);

            Assert.AreEqual(Heading.NORTH, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateAntiClockwiseFromNorth() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Rotate(false);

            Assert.AreEqual(Heading.WEST, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateAntiClockwiseFromWest() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.WEST;

            toyRobot.Place(location, space, heading);

            toyRobot.Rotate(false);

            Assert.AreEqual(Heading.SOUTH, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateAntiClockwiseFromSouth() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.SOUTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Rotate(false);

            Assert.AreEqual(Heading.EAST, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void RotateAntiClockwiseFromEast() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.EAST;

            toyRobot.Place(location, space, heading);

            toyRobot.Rotate(false);

            Assert.AreEqual(Heading.NORTH, toyRobot.CurrentHeading);
        }

        [TestMethod]
        public void MoveNorthFromZero() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(5, 5);
            var location = new Coordinate(0, 0);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(0,1));
        }

        [TestMethod]
        public void MoveSouthFromZeroIgnored() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(5, 5);
            var location = new Coordinate(0, 0);
            var heading = Heading.SOUTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(0, 0));
        }

        [TestMethod]
        public void MoveWestFromZeroIgnored() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(5, 5);
            var location = new Coordinate(0, 0);
            var heading = Heading.WEST;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(0, 0));
        }

        [TestMethod]
        public void MoveEastFromZero() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(5, 5);
            var location = new Coordinate(0, 0);
            var heading = Heading.EAST;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(1, 0));
        }



        [TestMethod]
        public void MoveNorthFromCenter() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(25, 25);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(25, 26));
        }

        [TestMethod]
        public void MoveSouthFromCenter() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(25, 25);
            var heading = Heading.SOUTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(25, 24));
        }

        [TestMethod]
        public void MoveWestFromCenter() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(25, 25);
            var heading = Heading.WEST;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(24, 25));
        }

        [TestMethod]
        public void MoveEastFromCenter() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(25, 25);
            var heading = Heading.EAST;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(26, 25));
        }

        [TestMethod]
        public void MoveWestFromEastBoundary() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(49, 25);
            var heading = Heading.WEST;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(48, 25));
        }

        [TestMethod]
        public void MoveEastFromEastBoundaryIgnored() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(49, 25);
            var heading = Heading.EAST;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(49, 25));
        }

        [TestMethod]
        public void MoveWestFromWestBoundaryIgnored() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(0, 25);
            var heading = Heading.WEST;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(0, 25));
        }

        [TestMethod]
        public void MoveEastFromWestBoundary() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(0, 25);
            var heading = Heading.EAST;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(1, 25));
        }

        [TestMethod]
        public void MoveSouthFromSouthBoundaryIgnored() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(25, 0);
            var heading = Heading.SOUTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(25, 0));
        }

        [TestMethod]
        public void MoveNorthFromSouthBoundary() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(25, 0);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(25, 1));
        }

        [TestMethod]
        public void MoveSouthFromNorthBoundary() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(25, 49);
            var heading = Heading.SOUTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(25, 48));
        }

        [TestMethod]
        public void MoveNorthFromNorthBoundaryIgnored() {
            var toyRobot = new ToyRobot();
            var space = new TableTop(50, 50);
            var location = new Coordinate(25, 49);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            toyRobot.Move(1);

            Assert.AreEqual(toyRobot.CurrentLocation, new Coordinate(25, 49));
        }


    }
}
