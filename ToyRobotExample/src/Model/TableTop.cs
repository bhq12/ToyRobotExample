using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class TableTop : TwoDimensionalSpace
    {
        public TableTop(uint xSize, uint ySize) : base(xSize, ySize) {
        
        }

        /// <summary>
        /// Determines whether a coordinate within the boundaries of the tabletop
        /// </summary>
        /// <param name="coordinate">The coordinate.</param>
        /// <returns>
        ///   <c>true</c> if [is valid location] [the specified coordinate]; otherwise, <c>false</c>.
        /// </returns>
        public override bool IsValidLocation(Coordinate coordinate) {

            var isXInBounds = 0 <= coordinate.X && coordinate.X < XSize;
            var isYInBounds = 0 <= coordinate.Y && coordinate.Y < YSize;

            return isXInBounds && isYInBounds;

        }

    }
}
