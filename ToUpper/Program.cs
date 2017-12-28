using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper
{
    class Program
    {
        public static string MakeComplement(string dna)
        {
            string res = "";
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 'A')
                {
                    res = res + 'T';
                }
                else if (dna[i] == 'T')
                {
                    res = res + 'A';
                }
                else if (dna[i] == 'C')
                {
                    res = res + 'G';
                }
                else if (dna[i] == 'G')
                {
                    res = res + 'C';
                }
                else
                {
                    res = res + ' ';
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(MakeComplement(s));
            Console.ReadKey();
        }
    }
}
