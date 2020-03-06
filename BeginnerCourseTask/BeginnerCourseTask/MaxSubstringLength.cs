using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubstringLength
{
    class MaxSubstringLength
    {
        public static int GetMaxSubstringLength(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int length = 1;
            int maxLength = 1;

            s = s.ToUpper();

            for (int i = 1; i < s.Length; ++i)
            {
                char currentSymbol = s[i];
                char previousSymbol = s[i - 1];

                if (currentSymbol == previousSymbol)
                {
                    length++;

                    if (length > maxLength)
                    {
                        maxLength = length;
                    }
                }
                else
                {
                    length = 1;
                }
            }

            return maxLength;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Длина максимальной подстроки в строке 45645555645456 = " + GetMaxSubstringLength("45645555645456"));
            Console.WriteLine("Длина максимальной подстроки в строке аааббдеггггв = " + GetMaxSubstringLength("аааббдеггггв      "));
            Console.WriteLine("Длина максимальной подстроки в строке 112233555 = " + GetMaxSubstringLength("112233555  "));
            Console.WriteLine("Длина максимальной подстроки в строке Эйяфьятлайокудль = " + GetMaxSubstringLength("Эйяфьятлайокудль   "));
            Console.WriteLine("Длина максимальной подстроки в строке аааббдегГггв = " + GetMaxSubstringLength("аааббдегГггв"));
            Console.WriteLine("Длина максимальной подстроки в строке /  ен  / = " + GetMaxSubstringLength("  ен   "));
            Console.WriteLine("Длина максимальной подстроки в строке /  ****  / = " + GetMaxSubstringLength("  ****  "));
            Console.WriteLine("Длина максимальной подстроки в строке /  &&&&  / = " + GetMaxSubstringLength("  &&&&  "));
            Console.WriteLine("Длина максимальной подстроки в строке /  / = " + GetMaxSubstringLength("  "));

            Console.ReadKey();
        }
    }
}
