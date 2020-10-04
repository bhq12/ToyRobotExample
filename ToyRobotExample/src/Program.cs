using System;
using System.Configuration;
using System.Collections.Specialized;
using ToyRobotExample.src.Controller;
using ToyRobotExample.src.Model;

namespace ToyRobotExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retrieve config variables from  CONFIG.xml
            var tableXSize = uint.Parse(ConfigurationManager.AppSettings.Get("TABLE_X_SIZE"));
            var tableYSize = uint.Parse(ConfigurationManager.AppSettings.Get("TABLE_Y_SIZE"));

            Console.WriteLine($"Beginning Simulation!\nTabletop size: {tableXSize} X {tableYSize}\nPlease type in commands followed by the ENTER key\nTo end the simulation use the commands QUIT or EXIT");

            var simulation = new ToyRobotTableTopSimulation(tableXSize, tableYSize);
            var controller = new ToyRobotTableTopSimulationController(simulation);

            controller.RunSimulation();

            Console.WriteLine("Simulation Ended :(");
        }
    }
}
