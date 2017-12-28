using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alt___Tab
{
    class Program
    {
        static int[] Betrayal(int n, int m)
        {
            int[] zeros = new int[n];
            for (int i = 0; i < n; i++)
            {
                zeros[i] = 0;
                if (i == m-1)
                {
                    zeros[i] = 1;
                }
            }
            return zeros;                                           
        }

        static void Output(ref int[] zeros, int k, int n)
        {
            int sec;
            for (int i = 0; i < k; i++)
            {
                int nvs = Array.IndexOf(zeros, 1);
                sec = int.Parse(Console.ReadLine());
                if ((sec) % n == Array.IndexOf(zeros, 1))
                {
                    zeros[0] = 1;
                    zeros[(sec) % n] = 0;
                }
                else if ((sec) % n > nvs)
                {
                    zeros[nvs] = 0;
                    zeros[( nvs +1 ) % n] = 1;
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] zeros = Betrayal(n, m);
            Output(ref zeros, k, n);
            Console.WriteLine(Array.IndexOf(zeros, 1) + 1);
            Console.ReadKey();
        }
    }
}
