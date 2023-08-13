using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_
{
    public class IfElseStatements
    {
        public IfElseStatements()
        {
            // If/Else Conditionals in C# 

            var test = 1;

            if (test == 1)
            {
                Console.WriteLine("this part is executed");
            } else
            {
                Console.WriteLine("I dont know what you want but im run");
            }

            bool isEqual = 5 == 5; // true
            bool notEqual = 5 != 1; // true

            bool greaterThan = 5 > 2; // true
            bool lessThan = 1 < 7; // true

            bool greaterThenEqual = 5 >= 5; // true
            bool lessThenEqual = 5 <= 5; // true

            // AND OR

            bool isEqualAndNotEqual = 4 == 4 && 4 != 7; // true
            bool isEqualOrNotEqual = 4 == 4 || 4 == 7; // true

            // Logical explanation example

            int number = 15;
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            int age = 18;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are not an adult yet");
            }

            int x = 7;
            int y = 5;
            int z = 10;
            if (x > y && x > z)
            {
                Console.WriteLine("x is the largest number");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("y is the largest number");
            }
            else
            {
                Console.WriteLine("z is the largest number");
            }

            string username = "admin";
            string password = "password123";
            if (username == "admin" && password == "password123")
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            int number2 = 15;
            if (number2 % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

        }
    }
}
