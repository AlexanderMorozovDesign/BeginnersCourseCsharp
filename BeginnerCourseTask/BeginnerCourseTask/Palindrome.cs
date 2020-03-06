using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j;)
            {
                if (!char.IsLetter(s[i]))
                {
                    i++;
                }
                else if (!char.IsLetter(s[j]))
                {
                    j--;
                }
                else if (char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            string[] s = { "Аргентина манит негра", "Saippuakivikauppias", "А роза упала на лапу Азора", "Я - арка края", "О, лета тело!", "trytrytr", "5454rt" };

            foreach (string element in s)
            {
                if (IsPalindrome(element))
                {
                    Console.WriteLine(element + " = Это строка палиндром");
                }
                else
                {
                    Console.WriteLine(element + " = Это строка НЕ палиндром");
                }
            }

            Console.ReadKey();
        }
    }
}
