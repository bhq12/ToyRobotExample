using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotExample.src.Model;
using System;

namespace ToyRobotTest
{
    [TestClass]
    public class HeadingExtensionTest
    {

        [TestMethod]
        public void ParseHeadingStringNorth() {
            var heading = HeadingExtensions.StringToHeading("NORTH");

            Assert.AreEqual(Heading.NORTH, heading);
        }
        [TestMethod]
        public void ParseHeadingStringEast() {
            var heading = HeadingExtensions.StringToHeading("EAST");

            Assert.AreEqual(Heading.EAST, heading);
        }
        [TestMethod]
        public void ParseHeadingStringSouth() {
            var heading = HeadingExtensions.StringToHeading("SOUTH");

            Assert.AreEqual(Heading.SOUTH, heading);
        }
        [TestMethod]
        public void ParseHeadingStringWest() {
            var heading = HeadingExtensions.StringToHeading("WEST");

            Assert.AreEqual(Heading.WEST, heading);
        }
        [TestMethod]
        public void ParseHeadingStringEmptyStringThrowsError() {
            Assert.ThrowsException<FormatException>(() => HeadingExtensions.StringToHeading(""));
        }

        [TestMethod]
        public void ParseHeadingStringInvalidStringThrowsError() {
            Assert.ThrowsException<FormatException>(() => HeadingExtensions.StringToHeading("this is not a valid heading that we plan on recognising"));
        }
    }
}
