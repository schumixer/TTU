using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string[] inputmas1 = input1.Split(' ');
            int[] mas1 = new int[inputmas1.Length];
            for (int i = 0; i < inputmas1.Length; i++)
            {
                mas1[i] = Convert.ToInt32(inputmas1[i]);
            }
            int input2 = int.Parse(Console.ReadLine());
            int[] inputmas2 = new int[input2];
            for (int i = 0; i < input2; i++)
            {
                inputmas2[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
