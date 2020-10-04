using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class ToyRobotTableTopSimulation {
        
        
        public TableTop TableTop { get; private set;}
        public ToyRobot ToyRobot { get; private set; }
        public ToyRobotTableTopSimulation(uint tableTopWidth, uint tableTopHeight) {
            ToyRobot = new ToyRobot();
            TableTop = new TableTop(tableTopWidth, tableTopHeight);
        }
    }
}
