using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_
{
    public class LoopsAlgorithm
    {
        public string CountRepeatingLetters(string str)
        {
            string code = "";
            int count = 1;

            for (int i = 0; i < str.Length - 1; i++)
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

        public string ReverseCode(string code)
        {
            string word = "";

            for (int i = 0; i < code.Length; i += 2)
            {
                char character = code[i];
                int count = int.Parse(code[i + 1].ToString());

                for(int num = 0; num < count; num++)
                {
                    word += character;
                }
            }

            return word;
        }
    }
}
