using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlString
{
    class UrlString
    {
        public static string GetServerName(string url)
        {
            int index = url.IndexOf("://") + 3;
            int shiftIndex = url.IndexOf("/", index);

            if (shiftIndex < 0)
            {
                return url.Substring(index);
            }

            return url.Substring(index, shiftIndex - index);
        }

        static void Main(string[] args)
        {
            string[] urls = { "http://SomeServerName/abcd/dfdf.htm?dfdf=dfdf", "http://SomeServerName" };

            Console.WriteLine("Массив строк из которых вычленяется имя сервера " + string.Join(", ", urls));
            Console.WriteLine();

            foreach (string url in urls)
            {
                Console.WriteLine("Строка из которой вычленяется имя сервера: " + url);
                Console.WriteLine("Имя сервера: " + GetServerName(url));
            }

            Console.ReadKey();
        }
    }
}
