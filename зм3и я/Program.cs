using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace зм3и_я
{

    class Program
    {
        public static int[] Arr(int N)
        {
            var Arr = new int[N];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = i;
            }
            return Arr;
        }

        static void Main(string[] args)
        { 
            int[] aRR = new int[5];
            aRR = Arr(5);
            for (int i = 0; i < 5; i++)
                Console.Write(aRR[i] + " ");
            Console.ReadKey();
        }

    }
}
