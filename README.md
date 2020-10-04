# ToyRobotExample
Project to simulate simple toy robot

A tabletop is simulated with a 5 x 5 grid on which a user can place a toy robot. This toy robot can be placed on a table in a certain location and moved around providing all instructed locations are within the bounds of the tabletop.

# How to run the program:
I have created packaged executables for osx/linux/windows as I am unsure what system the person assessing this is on.

Windows 10 (with visual studio license + installed):
- Open ToyrobotExample/ToyRobotExample.sln in visual studio. Press F5 to run application

Windows 10 (no visual studio):
Open command line interface in repo directory
>cd /build/win10-x64/
>ToyRobotExample.exe

Linux (tested on Ubuntu 18.04 LTS):
>cd /build/linux-x64/
Give the executable execute permissions for current user:
>chmod 755 ./ToyRobotExample
Run executable:
>./ToyRobotExample

Max OSX:
I don't have a mac so untested. I assume it's similar to linux above as OSX is unix based
1) Run the executable: /build/osx-x64/ToyRobotExample
2) Update these instructions with how you did it


# Using the application:

There are a number of commands to interact with the Robot:


PLACE X,Y,H

This command places the robot at a certain X/Y coordinate with heading H. Where heading is one of: NORTH, WEST, SOUTH, EAST
A robot must be PLACE-ed on the table before it can be moved around
A robot can be PLACE-ed multiple times in a row. After every PLACE all robot state is reset to the new location and heading (provided the PLACE command was in a valid location)
If the PLACE command references X,Y coordinates outside the tabletop boundaries, nothing happens

Note: X and Y coordinates are zero-indexed. So the Southwest corner (bottom left) of the tabletop is at (0,0) and the Northeast corner (top right) is at (4,4)

MOVE

Moves the toy robot one unit forward in the direction it is currently facing.

LEFT 

Rotate the robot 90 degrees left/anticlockwise

RIGHT

Rotate the robot 90 degrees right/clockwise

REPORT
This will print out the current robot state (location/heading) to command line

QUIT (also: EXIT)
This will end the simulation and exit the application



#Application config:
ToyRobotExample/App.config

This is an XML file containing the TABLE_X_SIZE and TABLE_Y_SIZE parameters should we want to alter the size of the tabletop in the simulation
Note: Altering this file will not effect the prebuilt executables in the /build/ directory as they are self contained. These must be rebuilt for this to have effect





//TODO: If this was a real application would want proper build/deployment tooling
# How to build self contained executables for the project:
NB: This is not the MS recomended way to build a project
(as noted in their documentation https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish )
but is simpler from a once-off "share application as a zip" perspective in order to have multiple executables for multiple environments as I'm unsure how this will be run and where

dotnet publish ToyRobotExample/ToyRobotExample.csproj -c Release -r win10-x64 -p:PublishSingleFile=true --self-contained true -o "./build/win10-x64/"
dotnet publish ToyRobotExample/ToyRobotExample.csproj -c Release -r linux-x64 -p:PublishSingleFile=true --self-contained true -o "./build/linux-x64/"
dotnet publish ToyRobotExample/ToyRobotExample.csproj -c Release -r osx-x64 -p:PublishSingleFile=true --self-contained true -o "./build/osx-x64/"


