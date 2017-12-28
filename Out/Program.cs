using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out
{
    class Program
    {

        static void Fun1(out string value)
        {
            value = "123";
            Console.WriteLine(value);
            if (false)
            {
                return;
            }
        }

        static void Fun2(ref string value)
        {
            Console.WriteLine(value);
            if (false)
            {
                return;
            }
            value = "123";
        }

        static void Main(string[] args)
        {
            string фыва;
            string фыва2 = "123";
            Fun1(out фыва);
            Fun2(ref фыва2);
            Console.ReadKey();
        }
    }
}
