using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лофт_в_бизнес_центре
{
    class Program
    {

        static int KolichestvoSecund(int[] pipl, int K)
        {
            bool zerocheck = true;
            int sum = 0 ;
            int zeros = 0;
            for (int i = 0; i < pipl.Length; i++)
            {
                if (i != pipl.Length - 1 && pipl [i] != 0)
                {
                    zerocheck = false;
                }
                else
                {
                    zerocheck = true;
                }
                if (pipl[i] == 0)
                {
                    zeros++;
                }
                if (pipl[i] % K == 0)
                {
                    sum = sum + pipl[i] / K * i;
                }
                else
                {
                    sum = sum + (pipl[i] + pipl[i] % K) / K * i;
                }
            }
            if (zerocheck && pipl.Length - zeros == 1)
            {
                return 2 * sum;
            }
            else
            {
                return 2 * sum - K;
            }
        }

        static int KolichestvoSecund2(int[] pipl, int K)
        {
            int sum = 0;
            int ans = 0;
            for (int i = 0; i < pipl.Length; i++)
            {
                sum = sum + pipl[i];
                if (sum >= K)
                    ans = ans + i * 2 * (sum / K);
            }
            if (sum != 0)
                ans = ans + (pipl.Length-1) * 2;
            return ans;
        }

                static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[] pipl = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                pipl[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(KolichestvoSecund2(pipl, K));
            Console.ReadKey();
        }
    }
}
