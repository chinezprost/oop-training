using System;
using System.Numerics;

namespace OOP_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cube cube = new Cube();
            
            cube.AddComponent(new Timer());
            cube.GetComponent<Timer>().CountForSeconds(10).RunSynchronously();
            


        }
    }
}