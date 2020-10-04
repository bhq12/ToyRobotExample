#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class ToyRobot {
        public Coordinate? CurrentLocation { get; private set; }

        public TwoDimensionalSpace? CurrentSpace { get; private set; }

        public Heading? CurrentHeading { get; private set; }

        public bool IsPlaced { get; private set; }


        public ToyRobot() {
            IsPlaced = false;
        }

        /// <summary>
        /// Places the robot at the specified location Coordinate in the specified TwoDimensionalSpace with the specified Heading.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="space">The space.</param>
        /// <param name="heading">The heading.</param>
        /// <exception cref="ArgumentException">Attempted to place in invalid location</exception>
        public void Place(Coordinate location, TwoDimensionalSpace space, Heading heading) {
            if (!space.IsValidLocation(location)) {
                throw new ArgumentException("Attempted to place in invalid location");
            }

            CurrentLocation = location;
            CurrentSpace = space;
            CurrentHeading = heading;
            IsPlaced = true;
        }

        /// <summary>
        /// Unset robot spatial properties
        /// </summary>
        public void UnPlace() {
            CurrentLocation = null;
            CurrentSpace = null;
            CurrentHeading = null;
            IsPlaced = false;
        }

        /// <summary>
        /// Rotates the robot in the specified direction
        /// </summary>
        /// <param name="isClockwiseDirection">if set to <c>true</c> rotate the robot clockwise.</param>
        public void Rotate(bool isClockwiseDirection) {
            if (!IsPlaced) {
                return;
            }

            if (isClockwiseDirection) {
                //Rotate 90° clockwise to the next valid heading
                CurrentHeading = (Heading?)((int?)(CurrentHeading + 90) % 360);
            } else {
                //Rotate 90° anti clockwise to the next valid heading
                CurrentHeading = (Heading?)((int?)(CurrentHeading - 90) % 360);

                if (CurrentHeading < 0) {
                    CurrentHeading += 360;
                }
            }
        }

        /// <summary>
        /// Moves robot the specified number of places.
        /// </summary>
        /// <param name="places">The places.</param>
        public void Move(int places) {
            if (!IsPlaced || CurrentLocation is null || CurrentSpace is null) {
                return;
            }
            
            var newLocation = new Coordinate(CurrentLocation.X, CurrentLocation.Y);
            switch (CurrentHeading) {
                case Heading.NORTH:
                    newLocation.Y += 1;
                    break;
                case Heading.EAST:
                    newLocation.X += 1;
                    break;
                case Heading.SOUTH:
                    newLocation.Y -= 1;
                    break;
                case Heading.WEST:
                    newLocation.X -= 1;
                    break;

            }
            if (CurrentSpace.IsValidLocation(newLocation)) {
                CurrentLocation = newLocation;
            }
        }
    }
}
