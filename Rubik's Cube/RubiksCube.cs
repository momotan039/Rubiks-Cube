using System;
using System.Collections.Generic;
using System.Text;

namespace Rubik_s_Cube
{

    public class RubiksCube
    {
        private char[,,] cube;

        public RubiksCube()
        {
            InitializeCube();
        }

        private void InitializeCube()
        {
            cube = new char[6, 3, 3];

            for (int face = 0; face < 6; face++)
            {
                char color = GetColorFromIndex(face);

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        cube[face, row, col] = color;
                    }
                }
            }
        }

        private char GetColorFromIndex(int index)
        {
            char[] colors = { 'W', 'R', 'G', 'B', 'Y', 'O' };
            return colors[index];
        }

        public void RotateFaceClockwise(int faceIndex)
        {
            RotateFace(faceIndex, true);
        }

        public void RotateFaceCounterClockwise(int faceIndex)
        {
            RotateFace(faceIndex, false);
        }

        private void RotateFace(int faceIndex, bool clockwise)
        {
            char[,] rotatedFace = new char[3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int newRow = row;
                    int newCol = col;

                    if (clockwise)
                    {
                        newRow = 2 - col;
                        newCol = row;
                    }
                    else
                    {
                        newRow = col;
                        newCol = 2 - row;
                    }

                    rotatedFace[newRow, newCol] = cube[faceIndex, row, col];
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    cube[faceIndex, row, col] = rotatedFace[row, col];
                }
            }

            // Update the adjacent face colors as well if needed.

            if (faceIndex == 0)  // Front face
            {
                RotateAdjacentFaceClockwise(1); // Rotate right face
            }
            else if (faceIndex == 1) // Right face
            {
                RotateAdjacentFaceCounterClockwise(0); // Rotate front face
            }
            else if (faceIndex == 2) // Top face
            {
                RotateAdjacentFaceClockwise(4); // Rotate bottom face
            }
            else if (faceIndex == 3) // Left face
            {
                RotateAdjacentFaceCounterClockwise(0); // Rotate front face
            }
            else if (faceIndex == 4) // Bottom face
            {
                RotateAdjacentFaceCounterClockwise(2); // Rotate top face
            }
            else if (faceIndex == 5) // Back face
            {
                RotateAdjacentFaceClockwise(3); // Rotate left face
            }
        }

        private void RotateAdjacentFaceClockwise(int faceIndex)
        {
            char[] temp = new char[3];

            for (int i = 0; i < 3; i++)
            {
                temp[i] = cube[faceIndex, 0, i];
            }

            for (int i = 0; i < 3; i++)
            {
                cube[faceIndex, 0, i] = cube[faceIndex, 2 - i, 0];
            }

            for (int i = 0; i < 3; i++)
            {
                cube[faceIndex, 2 - i, 0] = cube[faceIndex, 2, 2 - i];
            }

            for (int i = 0; i < 3; i++)
            {
                cube[faceIndex, 2, 2 - i] = cube[faceIndex, i, 2];
            }

            for (int i = 0; i < 3; i++)
            {
                cube[faceIndex, i, 2] = temp[i];
            }
        }

        private void RotateAdjacentFaceCounterClockwise(int faceIndex)
        {
            char[] temp = new char[3];

            for (int i = 0; i < 3; i++)
            {
                temp[i] = cube[faceIndex, i, 2];
            }

            for (int i = 0; i < 3; i++)
            {
                cube[faceIndex, i, 2] = cube[faceIndex, 2, 2 - i];
            }

            for (int i = 0; i < 3; i++)
            {
                cube[faceIndex, 2, 2 - i] = cube[faceIndex, 2 - i, 0];
            }

            for (int i = 0; i < 3; i++)
            {
                cube[faceIndex, 2 - i, 0] = cube[faceIndex, 0, i];
            }

            for (int i = 0; i < 3; i++)
            {
                cube[faceIndex, 0, i] = temp[i];
            }
        }

        public void PrintCube()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(cube[0, row, col] + " ");
                }
                Console.Write("  ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(cube[1, row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(cube[3, row, col] + " ");
                }
                Console.Write("  ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(cube[4, row, col] + " ");
                }
                Console.Write("  ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(cube[5, row, col] + " ");
                }
                Console.Write("  ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(cube[2, row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}