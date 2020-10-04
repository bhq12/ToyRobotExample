using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotExample.src.Model;
using ToyRobotExample.src.Controller;
using System;

namespace ToyRobotTest
{
    [TestClass]
    public class InputParserTest
    {
                
        [TestMethod]
        public void ParseCommandPlaceCommandParsedCorrectly() {
            Assert.AreEqual(ControllerOperation.PLACE, InputParser.ParseCommand("PLACE"));
        }

        [TestMethod]
        public void ParseCommandMoveCommandParsedCorrectly() {
            Assert.AreEqual(ControllerOperation.MOVE, InputParser.ParseCommand("MOVE"));
        }

        [TestMethod]
        public void ParseCommandLeftCommandParsedCorrectly() {
            Assert.AreEqual(ControllerOperation.ROTATE, InputParser.ParseCommand("LEFT"));
        }

        [TestMethod]
        public void ParseCommandRightCommandParsedCorrectly() {
            Assert.AreEqual(ControllerOperation.ROTATE, InputParser.ParseCommand("RIGHT"));
        }
        
        [TestMethod]
        public void ParseCommandReportCommandParsedCorrectly() {
            Assert.AreEqual(ControllerOperation.REFRESH_VIEW, InputParser.ParseCommand("REPORT"));
        }

        [TestMethod]
        public void ParseCommandEmptyCommandThrowsError() {
            Assert.ThrowsException<FormatException>(() => InputParser.ParseCommand(""));
        }

        [TestMethod]
        public void ParseCommandInvalidCommandThrowsError() {
            Assert.ThrowsException<FormatException>(() => InputParser.ParseCommand("this is not a valid command that we plan on recognising"));
        }
        
        [TestMethod]
        public void SplitInstructionCommandArgumentsNoArgumentsInstruction() {

            var splitInstruction = InputParser.SplitInstructionCommandArguments("MOVE");
            //Command
            Assert.AreEqual("MOVE", splitInstruction[0]);
            //Arguments
            Assert.AreEqual("", splitInstruction[1]);
        }

        [TestMethod]
        public void SplitInstructionCommandArgumentsArgumentsInstruction() {
            var splitInstruction = InputParser.SplitInstructionCommandArguments("PLACE 0,0,NORTH");
            //Command
            Assert.AreEqual("PLACE", splitInstruction[0]);
            //Arguments
            Assert.AreEqual("0,0,NORTH", splitInstruction[1]);
        }

        [TestMethod]
        public void SplitInstructionCommandArgumentsArgumentsInstructionArgumentContainsSpace() {
            var splitInstruction = InputParser.SplitInstructionCommandArguments("PLACE 0,0,NORTH EAST");
            //Command
            Assert.AreEqual("PLACE", splitInstruction[0]);
            //Arguments
            Assert.AreEqual("0,0,NORTH EAST", splitInstruction[1]);
        }

        [TestMethod]
        public void SplitArgumentsValidArguments() {
            var splitArguments = InputParser.SplitArguments("0,1,NORTH");

            Assert.AreEqual(3, splitArguments.Length);
            Assert.AreEqual("0", splitArguments[0]);
            Assert.AreEqual("1", splitArguments[1]);
            Assert.AreEqual("NORTH", splitArguments[2]);
        }

        [TestMethod]
        public void SplitArgumentsEmptyArguments() {
            var splitArguments = InputParser.SplitArguments("");
            Assert.AreEqual(1, splitArguments.Length);
            Assert.AreEqual("", splitArguments[0]);
        }

        [TestMethod]
        public void ParsePlaceLocationArgumentsEmptyStringThrowsError() {
            Assert.ThrowsException<FormatException>(() => InputParser.ParsePlaceLocationArguments(new string[] {"", "", ""}));
        }

        [TestMethod]
        public void ParsePlaceLocationArgumentsInvalidStringThrowsError() {
            Assert.ThrowsException<FormatException>(() => InputParser.ParsePlaceLocationArguments(new string[] { "asdf", "qwerty", "" }));
        }

        [TestMethod]
        public void ParsePlaceLocationArgumentsValidStringZero() {
            Assert.AreEqual(new Coordinate(0, 0), InputParser.ParsePlaceLocationArguments(new string[] { "0", "0", "" }));
        }

        public void ParsePlaceLocationArgumentsValidStringNonZero() {
            Assert.AreEqual(new Coordinate(5, 5), InputParser.ParsePlaceLocationArguments(new string[] { "5", "5", "" }));
        }


    }
}
