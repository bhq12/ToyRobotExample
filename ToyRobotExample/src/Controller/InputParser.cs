using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotExample.src.Model;

namespace ToyRobotExample.src.Controller
{
    public static class InputParser
    {

        /// <summary>
        /// Splits the instruction into separate command and argument(s).
        /// Format is: [command] [arguments]
        /// Command separated by single space. Followed by comma separated arguments list
        /// </summary>
        /// <param name="instruction">User input instruction.</param>
        /// <returns>
        ///   <br />
        /// </returns>
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

        /// <summary>
        /// Parses the command and returns associated ControllerOperation enum value
        /// </summary>
        /// <param name="commandName">Name of the command.</param>
        /// <returns></returns>
        /// <exception cref="FormatException">String was not recognised as valid robot command: '{commandName}'</exception>
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

        /// <summary>
        /// Splits comma separated arguments into array of strings
        /// </summary>
        /// <param name="arguments">The comma separated arguments string</param>
        /// <returns></returns>
        public static string[] SplitArguments(string arguments) {
            return arguments.Split(',');
        }

        /// <summary>
        /// Parses the place location arguments.
        /// </summary>
        /// <param name="arguments">Array of x/y location strings arguments[0]: string representing X coordinate. arguments[1]: string representing Y coordinate</param>
        /// <returns></returns>
        /// <exception cref="FormatException">Input was not recognised as valid location. X: '{arguments[0]}', Y: {arguments[1]}</exception>
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
