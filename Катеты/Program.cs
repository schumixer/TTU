using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Катеты
{
    class Program
    {
        static void Right1 (int[] mas, int n, int k)
        {
            int temp; // последняя ячейка
            for (int p = 0; p < k; p++)
            {
                temp = mas[n - 1];
                for (int i = n - 1; i > 0; i--) // сдвиг на 1 вправо
                {
                    mas[i] = mas[i - 1]; // сдвиг на 1 вправо
                }
                mas[0] = temp; // 0 ячейка = последней
            }
        }

        static void Left1 (int [] mas, int n, int k)
        {
            int temp; // последняя ячейка
            for (int p = 0; p < k; p++)
            {
                temp = mas[0];
                for (int i = 0; i < n - 1; i++) // сдвиг на 1 вправо
                {
                    mas[i] = mas[i + 1]; // сдвиг на 1 вправо
                }
                mas[n - 1] = temp; // 0 ячейка = последней
            }
        }

        static void Main(string[] args)
        {
            Console.Write("влево - 1, вправо - 2: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice != 1 && choice != 2)
                Console.WriteLine("Ну ты и отсталый!!!");
            else
            {
                int n = int.Parse(Console.ReadLine()); // кол-во яччеек массива
                int k = int.Parse(Console.ReadLine());
                int[] mas = new int[n]; // массив
                for (int i = 0; i < n; i++) // заполнение массива
                {
                    mas[i] = int.Parse(Console.ReadLine()); // заполнение массива
                }
                if (choice == 1)
                    Left1(mas, n, k);
                else if (choice == 2)
                    Right1(mas, n, k);
                foreach (var item in mas) // вывод
                {
                    Console.Write(item + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
