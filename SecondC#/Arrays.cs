using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_
{
    public class Arrays
    {
       public Arrays()
        {
            // Array - collection of fixed set of values. Arrays are used to store multiple values in a single variable;

            Console.WriteLine("Arrays");

            // Fixed

            int[] firstArr = new int[2];

            string[] stringArr = new string[2];

            object[] objectsArr = new object[4];

            firstArr[0] = 1;

            Console.WriteLine(firstArr);
            Console.WriteLine(stringArr);
            Console.WriteLine(objectsArr);

            // Dynamic

            int[] staticArrays = new int[] { 1, 2, 3, 4 };

            Console.WriteLine(staticArrays[0]);

            foreach (int num in staticArrays)
            {
                Console.WriteLine(num);
            }

            var avargeValue = staticArrays.Average();

            Console.WriteLine(avargeValue);

            // Array - right click -> go to definition
        }
    }
}
