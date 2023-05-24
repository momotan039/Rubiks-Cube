using System;

namespace Rubik_s_Cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cube3x3 cube3X3 = new Cube3x3();
            cube3X3.Display();

            Console.ReadLine();
        }
    }
}
