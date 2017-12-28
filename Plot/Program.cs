using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    class Program
    {
        /*
         * счетчик для каждой выршины
         * обнулять подъем и спуск 
         * когда нашли подъем и спуск мы завершаем проход и начинаем следующий
         * случай, когда нет ответа
         * 
         */ 
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] mas = new int[N];
            bool podem = false;
            bool spusk = false;
            int begin = 0;
            int konec = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        podem = true;
                    }
                    if (mas[i] > mas[j])
                    {
                        spusk = true;
                    }
                    if (spusk == true && spusk == podem && j - i < konec - begin)
                    {
                        begin = i + 1;
                        konec = j + 1;
                    }
                }
            }
            Console.WriteLine(begin + "\n" + konec);
            Console.ReadKey();
        }
    }
}
