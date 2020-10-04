using System;
using ToyRobotExample.src.Controller;
using ToyRobotExample.src.Model;

namespace ToyRobotExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning Simulation!");

            var simulation = new ToyRobotTableTopSimulation(5, 5);
            var controller = new ToyRobotTableTopSimulationController(simulation);

            controller.RunSimulation();

            Console.WriteLine("Simulation Ended :(");
        }
    }
}
