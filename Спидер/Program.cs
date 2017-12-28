using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace олимпиадаN_1
{
    class Program
    {
        static int[] Vozvrat(string ver)
        {
            string[] maspoint = ver.Split('.');
            int[] digitmas = new int[maspoint.Length];
            for (int i = 0; i < maspoint.Length; i++)
            {
                digitmas[i] = Convert.ToInt32(maspoint[i]);
            }
            return digitmas;
        }

        public bool HigherVersion(string ver1, string ver2)
        {
            int[] inputmas1 = Vozvrat(ver1);
            int[] inputmas2 = Vozvrat(ver2);
            for (int i = 0; i < inputmas1.Length; i++)
            {
                if (inputmas1[i] > inputmas2[i])
                {
                    return true;
                }
                else if (inputmas1[i] == inputmas2[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
                return false;
        }

        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            bool c = HigherVersion(a, b);
            Console.Write(c);
            Console.ReadKey();
        }
    }
}