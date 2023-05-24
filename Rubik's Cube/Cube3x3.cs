using System;
using System.Collections.Generic;
using System.Text;

namespace Rubik_s_Cube
{
    class Cube3x3
    {
        private char[,,] cubeGrid;

        public Cube3x3()
        {
            cubeGrid = new char[6, 3, 3];
            this.Initialize();
        }

        public void Initialize()
        {
            // Initialize the cube with solved state
            for (int face = 0; face < 6; face++)
            {
                char color = GetFaceColor(face);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        cubeGrid[face, i, j] = color;
                    }
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
            for (int r = 0; r < 3; r++)
            {
                for (int face = 0; face < 6; face++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write("| " + cubeGrid[face, r, c] + " ");
                    }
                    Console.Write("| ");
                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        private char GetFaceColor(int face)
        {
            // Define the color for each face of the cube
            switch (face)
            {
                case 0: // Up (U)
                    return 'W'; // 'W' represents white color
                case 1: // Down (D)
                    return 'Y'; // 'Y' represents yellow color
                case 2: // Front (F)
                    return 'G'; // 'G' represents green color
                case 3: // Back (B)
                    return 'B'; // 'B' represents blue color
                case 4: // Left (L)
                    return 'O'; // 'O' represents orange color
                case 5: // Right (R)
                    return 'R'; // 'R' represents red color
                default:
                    throw new ArgumentOutOfRangeException("Invalid face index");
            }
        }
    }
}
