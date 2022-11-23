using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace OOP_Training
{
    public class Components
    {
        
    }


    public class Transform : Components
    {
        public Vector3 Position = Vector3.Zero;
        public Vector3 Scale = Vector3.One;
        public Vector3 Rotation = Vector3.Zero;
        public bool IsActive = true;
        
        
        
        
        
    }
    
    
    public class Timer : Components
    {
        public async Task CountForSeconds(int value)
        {
            if (value < 1)
                return;

            while (value > 0)
            {
                Console.WriteLine($"Counting: {value}");
                value--;
                Task.Delay(1000).Wait();
            }

        }
    }
    
    
}