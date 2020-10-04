using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class ToyRobotTableTopSimulation {
        
        
        public TableTop TableTop { get; private set;}
        public ToyRobot ToyRobot { get; private set; }
        public ToyRobotTableTopSimulation(uint tableXSize, uint tableYSize) {
            ToyRobot = new ToyRobot();
            TableTop = new TableTop(tableXSize, tableYSize);
        }
    }
}
