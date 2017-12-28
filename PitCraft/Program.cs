using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitCraft
{
    class Program
    {

        static int[] Mas()
        {
            string s = Console.ReadLine();
            string[] input = s.Split(' ');
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = int.Parse(input[i]);
            }
            return output;
        }
        static void Main(string[] args)
        {
            int[] off = Mas();
            int[] fly = Mas();
            int[] hour = Mas();
            int[] land = new int[3] { 0, fly[0] + off[0] , fly[1] +  off[1]};
            if (land[2] > 60)
            {
                land[1] = land[1] + land[2] / 60;
                land[2] = land[2] % 60;
            }
            if (hour[1] - hour[0] >= 12)
            {
                land[1] = land[1] + 48 - (hour[1] - hour[0]);
            }
            else
            {
                land[1] = land[1] + hour[1] - hour[0];
            }
            if (land[1] >= 24)
            {
                land[0] = land[1] / 24;
                land[1] = land[1] % 24;
            }
            Console.ReadKey();
        }
    }
}
