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
            var space = new TwoDimensionalSpace(1, 1);
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
            var space = new TwoDimensionalSpace(1, 1);
            var location = new Coordinate(0, 0);
            var heading = Heading.NORTH;

            toyRobot.Place(location, space, heading);

            toyRobot.UnPlace();

            Assert.AreEqual(false, toyRobot.IsPlaced);
            Assert.AreEqual(null, toyRobot.CurrentSpace);
            Assert.AreEqual(null, toyRobot.CurrentLocation);
            Assert.AreEqual(null, toyRobot.CurrentHeading);

        }

    }
}
