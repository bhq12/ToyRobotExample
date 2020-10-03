using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class Coordinate
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Coordinate(int x, int y) {
            X = x;
            Y = y;
        }

        public override bool Equals(object other) {

            var comparator = other as Coordinate;
            if (comparator is null) {
                return false;
            }

            if (this.X == comparator.X && this.Y == comparator.Y) {
                return true;
            }
            return false;
        }
    }
}
