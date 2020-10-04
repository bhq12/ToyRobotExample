using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public static class HeadingExtensions
    {
        public static string HeadingToString(Heading heading) {
            switch (heading) {
                case Heading.NORTH:
                    return "NORTH";
                case Heading.EAST:
                    return "EAST";
                case Heading.SOUTH:
                    return "SOUTH";
                case Heading.WEST:
                    return "WEST";
                default:
                    return "NULL";
            }
        }

        public static Heading StringToHeading(string heading) {
            if (heading == "NORTH") {
                return Heading.NORTH;
            }
            else if (heading == "EAST") {
                return Heading.EAST;
            }
            else if (heading == "SOUTH") {
                return Heading.SOUTH;
            }
            else if (heading == "WEST") {
                return Heading.WEST;
            }
            else {
                throw new FormatException($"String was not recognised as valid heading: '{heading}'");
            }
        }
    }
}
