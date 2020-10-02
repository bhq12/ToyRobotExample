﻿#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotExample.src.Model
{
    public class ToyRobot
    {
        public Coordinate? CurrentLocation { get; private set; }

        public TwoDimensionalSpace? CurrentSpace { get; private set; }

        public Heading? CurrentHeading { get; private set; }

        public bool IsPlaced { get; private set; }


        public ToyRobot() {
            IsPlaced = false;
        }

        public void Place(Coordinate location, TwoDimensionalSpace space, Heading heading) {
            CurrentLocation = location;
            CurrentSpace = space;
            CurrentHeading = heading;
            IsPlaced = true;
        }

        public void UnPlace() {
            CurrentLocation = null;
            CurrentSpace = null;
            CurrentHeading = null;
            IsPlaced = false;
        }

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
    }
}