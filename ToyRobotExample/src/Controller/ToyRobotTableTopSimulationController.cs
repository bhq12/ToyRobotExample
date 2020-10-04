using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotExample.src.Model;

namespace ToyRobotExample.src.Controller
{
    public class ToyRobotTableTopSimulationController
    {
        public ToyRobotTableTopSimulation Simulation { get; private set; }
        
        public ToyRobotTableTopSimulationController(ToyRobotTableTopSimulation simulation) {
            Simulation = simulation;
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
            throw new NotImplementedException();
        }
    }
}
