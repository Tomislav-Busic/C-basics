using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_
{
    public class Loops
    {
        public Loops()
        {
            Console.WriteLine("Loops");

            // For loop C#

            // for (initializer, condition, interator) 
            // { do some task over and over }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Value of {i}");
            }

            // reverse

            for (int i = 0; i > 3; i--)
            {
                Console.WriteLine($"Value of {i}");
            }

        }
    }
}
