using System;
using System.Numerics;

namespace OOP_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cube cube = new Cube
            {
                Position = new Vector3(0, 0, 0),
                Rotation = new Vector3(0, 0, 0)
            };
            cube.AddComponent<Timer>();
            
        }
    }
}