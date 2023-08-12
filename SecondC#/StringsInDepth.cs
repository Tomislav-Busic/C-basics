using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_
{
    public class StringsInDepth
    {
        public StringsInDepth()
        {

            Console.WriteLine("Strings In-Depth");

            // Strings - an object whose value is text.

            // reference type

            // double
            string word = "task";

            // single
            char[] letters = new char[] { 't', 'a', 's', 'k', 's' };

            Console.WriteLine(word);
            Console.WriteLine(letters);

            // VALUE TYPES CANNOT BE NULL
            string message = null;

            // Literal vs Verbatim
            string filePath = "c:\\ProgramFiles";

            string filePathVerbatim = @"c:\\ProgramFiles";

            // Strings immutability (Read only)

            string s1 = "Hello ";
            string s2 = s1;
            s2 += "World";

            Console.WriteLine(s2);

            // String Interpolation + Composite Formatting

            string firstName = "Tomislav";
            string lastName = "Bušić";

            // String Interpolation
            Console.WriteLine($"My name {firstName} {lastName}");

            // Composite Formatting
            Console.WriteLine("My name {0} {1}", firstName, lastName);
        }
    }
}
