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
                
            };
            cube.AddComponent<Timer>(new Timer());
            var x = cube.GetComponent<Timer>();
            x.CountForSeconds(10);


        }
    }
}