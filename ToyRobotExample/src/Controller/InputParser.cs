using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotExample.src.Model;

namespace ToyRobotExample.src.Controller
{
    public static class InputParser
    {

        public static string[] SplitInstructionCommandArguments(string instruction) {

            var firstSpaceIndex = instruction.IndexOf(' ');

            //no space in instruction. i.e. command has no arguments, whole instruction is command
            if (firstSpaceIndex == -1) {
                return new string[] { instruction, "" };
            }

            var command = instruction.Substring(0, firstSpaceIndex);
            var arguments = instruction.Substring(firstSpaceIndex + 1);

            return new string[] { command, arguments };
        }
        
        public static ControllerOperation ParseCommand(string commandName) {

            if (commandName == "MOVE") {
                return ControllerOperation.MOVE;
            }
            else if (commandName == "LEFT" || commandName == "RIGHT") {
                return ControllerOperation.ROTATE;
            }
            else if (commandName == "PLACE") {
                return ControllerOperation.PLACE;
            }
            else if (commandName == "REPORT") {
                return ControllerOperation.REFRESH_VIEW;
            }
            else {
                throw new FormatException($"String was not recognised as valid robot command: '{commandName}'");
            }
        }

        public static string[] SplitArguments(string arguments) {
            return arguments.Split(',');
        }

        public static Heading ParseHeadingString(string heading) {

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

        public static Coordinate ParsePlaceLocationArguments(string[] arguments) {
            try {
                var x = int.Parse(arguments[0]);
                var y = int.Parse(arguments[1]);
                return new Coordinate(x, y);
            }
            catch (FormatException e) {
                throw new FormatException($"Input was not recognised as valid location. X: '{arguments[0]}', Y: {arguments[1]}");
            }
        }
    }
}
