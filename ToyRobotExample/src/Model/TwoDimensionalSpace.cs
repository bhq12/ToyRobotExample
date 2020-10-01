using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class TwoDimensionalSpace
    {
        //Unsigned int as negative size tabletop is nonsensical
        public uint XSize { get; set; }
        public uint YSize { get; set; }

        public TwoDimensionalSpace(uint xSize, uint ySize)
        {
            XSize = xSize;
            YSize = ySize;
        }
    }
}
