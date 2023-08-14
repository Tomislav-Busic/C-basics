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

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine($"Value of {i}");
            }

            var fibNumbers = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13 };

            foreach(int el in fibNumbers)
            {
                Console.WriteLine(el);
            }

        }
    }
}
