using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OOP_Training
{
    public class Components<T>
    {
        
        
        
    }


    
    public class Timer : Components<Timer>
    {
        public async Task CountForSeconds(int value)
        {
            if (value < 1)
                return;

            while (value > 0)
            {
                Console.WriteLine($"Counting: {value}");
                value--;
                Task.Delay(1000);

            }

        }
    }
}