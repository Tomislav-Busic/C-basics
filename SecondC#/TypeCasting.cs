using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_
{
    public class TypeCasting
    {
        public TypeCasting()
        {
            Console.WriteLine("Type Casting");

            // Type Casting in C#

            // Converting data after it has been assigned at compilation
            // Implicit and Explicit

            double x = 2345.43;
            int a;
            // Cast double to int. EXPLICIT CONVERSATION
            a = (int)x;
            Console.WriteLine(a);

            // String to int;

            string value = "2345234";
            int result;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine("Success: " + result);
            }
            else
            {
                Console.WriteLine("Failure.");
            }
        }
    }
}
