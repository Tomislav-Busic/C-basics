using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_
{
    public class LoopsAlgorithm
    {
        public static string CountRepeatingLetters(string str)
        {
            string code = "";
            int count = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[i + 1])
                {
                    count++;
                } else
                {
                    code += str[1] + count.ToString();
                    count = 1;
                }
            }

            return code;
        }
    }
}
