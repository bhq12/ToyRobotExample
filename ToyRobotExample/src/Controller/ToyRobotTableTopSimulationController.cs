using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ToyRobotExample.src.Model;
using ToyRobotExample.src.View;

namespace ToyRobotExample.src.Controller
{
    public class ToyRobotTableTopSimulationController
    {
        public ToyRobotTableTopSimulation Simulation { get; private set; }
        public ToyRobotTableTopSimulationView View { get; private set; }
        
        public ToyRobotTableTopSimulationController(ToyRobotTableTopSimulation simulation) {
            Simulation = simulation;
            View = new ToyRobotTableTopSimulationView(simulation);
        }

        public void RunSimulation() {
            while (true) {
                var input = Console.ReadLine();
                try {
                    if (input == "QUIT" || input == "EXIT") {
                        break;
                    }
                    else {
                        var splitCommandArguments = InputParser.SplitInstructionCommandArguments(input);
                        var commandString = splitCommandArguments[0];
                        var arguments = InputParser.SplitArguments(splitCommandArguments[1]);

                        var command = InputParser.ParseCommand(commandString);

                        if (command == ControllerOperation.MOVE) {
                            MoveRobot();
                        }
                        else if (command == ControllerOperation.PLACE) {
                            var locationCoordinate = InputParser.ParsePlaceLocationArguments(arguments);
                            var heading = HeadingExtensions.StringToHeading(arguments[2]);
                            PlaceRobot(locationCoordinate, heading);
                        }
                        else if (command == ControllerOperation.REFRESH_VIEW) {
                            RefreshView();
                        }
                        else if (command == ControllerOperation.ROTATE) {
                            //Command is LEFT or RIGHT indicating rotation direction, i.e. expected input for RotateRobot() function
                            RotateRobot(commandString);
                        }

                    }
                }
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void PlaceRobot(Coordinate location, Heading heading) {
            Simulation.ToyRobot.Place(location, Simulation.TableTop, heading);
        }


        public void MoveRobot() {
            Simulation.ToyRobot.Move(1);
        }

        public void RotateRobot(string direction) {
            if (direction == "RIGHT") {
                Simulation.ToyRobot.Rotate(true);
            }
            else if (direction == "LEFT") {
                Simulation.ToyRobot.Rotate(false);
            }
        }

        public void RefreshView() {
            View.Refresh();
        }
    }
}
