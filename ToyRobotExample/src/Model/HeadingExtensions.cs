using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public static class HeadingExtensions
    {
        /// <summary>
        /// Converts Heading enum values to associated string
        /// </summary>
        /// <param name="heading">The heading.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts Heading enum strings to associated enum value
        /// </summary>
        /// <param name="heading">The heading string representation</param>
        /// <returns></returns>
        /// <exception cref="FormatException">String was not recognised as valid heading: '{heading}'</exception>
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
