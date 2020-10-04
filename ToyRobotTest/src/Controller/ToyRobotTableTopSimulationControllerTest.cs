using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotExample.src.Model;
using ToyRobotExample.src.Controller;
using System;

namespace ToyRobotTest
{
    [TestClass]
    public class ToyRobotTableTopSimulationControllerTest
    {

        [TestMethod]
        public void ControllerPlaceRobot() {
            var simulation = new ToyRobotTableTopSimulation(5, 5);
            var controller = new ToyRobotTableTopSimulationController(simulation);

            Assert.AreEqual(false, simulation.ToyRobot.IsPlaced);

            controller.PlaceRobot(new Coordinate(0, 0), Heading.NORTH);

            Assert.AreEqual(true, simulation.ToyRobot.IsPlaced);
        }

        [TestMethod]
        public void ControllerMoveRobot() {
            var simulation = new ToyRobotTableTopSimulation(5, 5);
            var controller = new ToyRobotTableTopSimulationController(simulation);

            controller.PlaceRobot(new Coordinate(0, 0), Heading.NORTH);

            controller.MoveRobot();

            Assert.AreEqual(new Coordinate(0,1), simulation.ToyRobot.CurrentLocation);
        }

        [TestMethod]
        public void ControllerRotateRobotLeft() {
            var simulation = new ToyRobotTableTopSimulation(5, 5);
            var controller = new ToyRobotTableTopSimulationController(simulation);

            controller.PlaceRobot(new Coordinate(0, 0), Heading.NORTH);

            controller.RotateRobot("LEFT");

            Assert.AreEqual(Heading.WEST, simulation.ToyRobot.CurrentHeading);
        }

        [TestMethod]
        public void ControllerRotateRobotRight() {
            var simulation = new ToyRobotTableTopSimulation(5, 5);
            var controller = new ToyRobotTableTopSimulationController(simulation);

            controller.PlaceRobot(new Coordinate(0, 0), Heading.NORTH);

            controller.RotateRobot("RIGHT");

            Assert.AreEqual(Heading.EAST, simulation.ToyRobot.CurrentHeading);
        }

        [TestMethod]
        public void ControllerRefreshViewFailingTest() {
            var simulation = new ToyRobotTableTopSimulation(5, 5);
            var controller = new ToyRobotTableTopSimulationController(simulation);

            controller.PlaceRobot(new Coordinate(0, 0), Heading.NORTH);

            controller.RefreshView();
        }

    }
}
