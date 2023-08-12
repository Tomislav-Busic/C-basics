using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_
{
    public class DataTypes
    {
        public DataTypes()
        {
            // DATA TYPES

            var name = "Tomislav";
            Console.WriteLine(name);

            int integerExe = 7 + 5;
            string b = "34524" + "83457";
            byte c = 255; // 0-255 max
            double testDouble = 14.45;
            float testFloat = 23.2323f; // f to the end
            decimal testDecimal = .1212356m; // m to the end

            Console.WriteLine($"Types of data: {integerExe} {b} {c} {testDouble} {testFloat} {testDecimal}");
        }
    }
}
