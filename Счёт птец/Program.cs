using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Счёт_птец
{
    class Program
    {
        static void Main(string[] args)
        {
            int periodvoron = int.Parse(Console.ReadLine());
            int periodutok = int.Parse(Console.ReadLine());
            int utkostay = int.Parse(Console.ReadLine());
            int periodgolub = int.Parse(Console.ReadLine());
            int ptitzi = 0;
            for (int i = 480; i < 1200; i += periodvoron)
            {
                if (i < 660 || (i > 749 && i < 900) || (i > 989 && i < 1020) || i > 1109)
                {
                    ptitzi++;
                }
            }
            for (int i = 600; i < 1020; i += periodutok)
            {
                if (i < 660 || (i > 749 && i < 900) || (i > 989 && i < 1020) || i > 1109)
                {
                    ptitzi += utkostay;
                }
            }
            for (int i = 420; i < 1200; i += periodgolub)
            {
                if (i < 660 || (i > 749 && i < 900) || (i > 989 && i < 1020) || i > 1109)
                {
                    ptitzi++;
                }
            }
            Console.WriteLine(ptitzi);
            Console.ReadKey();
        }
    }
}
