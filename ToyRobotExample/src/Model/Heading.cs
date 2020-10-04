using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    /// <summary>
    /// Collection of heading representations. Value is equal to the rotation of the heading measured in degrees clockwise from NORTH (zero)
    /// </summary>
    public enum Heading
    {
        NORTH = 0,
        EAST = 90,
        SOUTH = 180,
        WEST = 270
    }
}
