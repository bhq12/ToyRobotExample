using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class TableTop
    {
        //Unsigned int as negative size tabletop is nonsensical
        uint XSize { get; set; }
        uint YSize { get; set; }

        public TableTop(uint xSize, uint ySize) {
            XSize = xSize;
            YSize = ySize;
        }

        public bool IsValidPlace(Coordinate coordinate) {

            var isXInBounds = 0 <= coordinate.X && coordinate.X < XSize;
            var isYInBounds = 0 <= coordinate.Y && coordinate.Y < YSize;

            return isXInBounds && isYInBounds;

        }

    }
}
