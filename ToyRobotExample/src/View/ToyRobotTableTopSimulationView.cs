using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotExample.src.Model;

namespace ToyRobotExample.src.View
{
    public class ToyRobotTableTopSimulationView
    {
        public ToyRobotTableTopSimulation Simulation { get; private set; }

        public ToyRobotTableTopSimulationView(ToyRobotTableTopSimulation simulation) {
            Simulation = simulation;
        }

        public void Refresh() {
            var x = Simulation.ToyRobot.CurrentLocation.X;
            var y = Simulation.ToyRobot.CurrentLocation.Y;
            var heading = Simulation.ToyRobot.CurrentHeading;
            Console.WriteLine($"{x},{y},{heading}");
        }
    }
}
