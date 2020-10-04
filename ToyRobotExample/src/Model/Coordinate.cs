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

        /// <summary>
        /// Override == operator for Coordinate object
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
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
