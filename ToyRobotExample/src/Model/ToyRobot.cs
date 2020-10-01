#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class ToyRobot
    {
        public Coordinate? CurrentLocation { get; set; }

        public TwoDimensionalSpace? CurrentSpace { get; set; }

        public Heading? CurrentHeading { get; set; }

        public bool IsPlaced;



        public ToyRobot() {
            IsPlaced = false;
        }

        public void Place(Coordinate location, TwoDimensionalSpace space, Heading heading) {
            CurrentLocation = location;
            CurrentSpace = space;
            CurrentHeading = heading;
            IsPlaced = true;
        }

        public void UnPlace() {
            CurrentLocation = null;
            CurrentSpace = null;
            CurrentHeading = null;
            IsPlaced = false;
        }
    }
}
