using System;
using System.Numerics;

namespace OOP_Training
{
    public class Cube : GameObject
    {
        public Cube()
        {
            this.components.Add(new Transform());
            Console.WriteLine("Object initialized.");
        }
    }
}