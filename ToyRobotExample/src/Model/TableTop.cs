using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class TableTop : TwoDimensionalSpace
    {
        public TableTop(uint xSize, uint ySize) : base(xSize, ySize) {
        
        }

        public bool IsValidLocation(Coordinate coordinate) {

            var isXInBounds = 0 <= coordinate.X && coordinate.X < XSize;
            var isYInBounds = 0 <= coordinate.Y && coordinate.Y < YSize;

            return isXInBounds && isYInBounds;

        }

    }
}
