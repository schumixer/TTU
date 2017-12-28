using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рек
{
    class Program
    {
       
        static void FeoFun(string input, ref List<string> L)
        {
            if (input.Length == 3 && !L.Contains(input))
            {
                L.Add(input);
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("*");
                FeoFun(input.Substring(0, i) + input.Substring(i + 1, input.Length - i - 1), ref L);
            }
        }

        static void Main(string[] args)
        {
            List<string> L = new List<string>();
            FeoFun("111111111110011111111", ref L);
            foreach ( var v in L)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine(L.Count());

            Console.ReadKey();
        }
    }
}
