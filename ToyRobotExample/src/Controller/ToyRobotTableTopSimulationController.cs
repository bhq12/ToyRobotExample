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

        /// <summary>
        /// Runs the simulation. Waits on user input, then parses and performs associated action
        /// </summary>
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
                catch (Exception e) {
                    Console.WriteLine("UNEXPECTED ERROR");
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Places the robot at a coordinate location with a direction heading
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="heading">The heading.</param>
        public void PlaceRobot(Coordinate location, Heading heading) {
            Simulation.ToyRobot.Place(location, Simulation.TableTop, heading);
        }


        /// <summary>
        /// Moves the robot one place according to the current heading
        /// </summary>
        public void MoveRobot() {
            Simulation.ToyRobot.Move(1);
        }

        /// <summary>
        /// Rotates the robot by adjusting the heading
        /// </summary>
        /// <param name="direction">The direction of rotation.</param>
        public void RotateRobot(string direction) {
            if (direction == "RIGHT") {
                Simulation.ToyRobot.Rotate(true);
            }
            else if (direction == "LEFT") {
                Simulation.ToyRobot.Rotate(false);
            }
        }

        /// <summary>
        /// Refreshes the view.
        /// </summary>
        public void RefreshView() {
            View.Refresh();
        }
    }
}
