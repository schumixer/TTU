using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server
{
    class Program
    {

        static string[] InPutInSplit()
        {
            string input = Console.ReadLine();
            string[] output = input.Split(':');
            return output;
        }

        static int[] SplitToInt32(string[] input)
        {
            int[] output = new int[4] { 0 , 0 , 0 , 0 };
            for (int i = 0; i < 3; i++)
            {
                output[i + 1] = Convert.ToInt32(input[i]);
            }
            return output;
        }

        static int[] Zoderdjzhka(int[] fromclient, int[] toclient)
        {
            int b = toclient[3] + toclient[2] * 60 + toclient[1] * 3600;
            int a = fromclient[3] + fromclient[2] * 60 + fromclient[1] * 3600;
            int c = b - a;
            if (c < 0)
                c = c + 24 * 60 * 60;
            int[] zoderdjzhka = new int[4] { 0, 0, 0, 0 };
            c = c / 2;
            zoderdjzhka[0] = c / 86400;
            c = c % 86400;
            zoderdjzhka[1] = c / 3600;
            c = c % 3600;
            zoderdjzhka[2] = c / 60;
            c = c % 60;
            zoderdjzhka[3] = c;
            return zoderdjzhka;
        }

        static int[] PravillnoyeVremmiya(int[] server, int[] zoderdjzhka)
        {
            int[] pravtime = new int[4] { 0, 0, 0, 0 };
            for (int i = 3; i >= 0; i--)
            {
                pravtime[i] = pravtime[i] + server[i] + zoderdjzhka[i];
                if (i > 1 && pravtime[i] >= 60)
                {
                    pravtime[i - 1] = pravtime[i] / 60;
                    pravtime[i] = pravtime[i] % 60;
                }
                else if (i == 1 && pravtime[i] >= 24)
                {
                    pravtime[i - 1] = pravtime[i] / 24;
                    pravtime[i] = pravtime[i] % 24;
                }
            }
            return pravtime;
        }

        static void Main(string[] args)
        {
            int[] zoderdjzhka = Zoderdjzhka(SplitToInt32(InPutInSplit()), SplitToInt32(InPutInSplit()));
            int[] pravtime = PravillnoyeVremmiya(SplitToInt32(InPutInSplit()), zoderdjzhka);
            for (int i = 0; i < 4; i++)
            {
                Console.Write(pravtime[i]);
                if (i < 3)
                {
                    Console.Write(":");
                }
            }
            Console.ReadKey();
        }
    }
}
