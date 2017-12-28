using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            int color;
            Random num = new Random();
            string[] keys = System.IO.File.ReadAllLines(@"F:\Keys.txt");
            while (true)
            {
                color = num.Next(0, 9999);
                Console.Write(keys[color]);
            }
            Console.ReadLine();
        }
    }
}
