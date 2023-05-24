using System;
using System.Collections.Generic;
using System.Text;

namespace Rubik_s_Cube
{
    using System;

        class Cube
        {
            private char[,] cubeGrid;

            public Cube()
            {
                cubeGrid = new char[3, 3];
            }

            public void Initialize()
            {
                // Initialize the cube with solved state
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        cubeGrid[i, j] = 'W'; // 'W' represents white color
                    }
                }
            }

            public void Scramble()
            {
                // Perform random cube rotations to scramble the cube
                // Implement your scrambling algorithm here
            }

            public void Display()
            {
                // Display the current state of the cube
                Console.WriteLine("-------------");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("| " + cubeGrid[i, j] + " ");
                    }
                    Console.WriteLine("|");
                    Console.WriteLine("-------------");
                }
            }
        }

}
