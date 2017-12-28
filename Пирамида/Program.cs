using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пирамида
{

    class Program
    {
        static int[,] Input(int number)
        {
            string[] input = new string[2];
            int[,] output = new int[number, 2];
            for (int i = 0; i < number; i++)
            {
                input = Console.ReadLine().Split(' ');
                output[i, 0] = Convert.ToInt32(input[0]);
                output[i, 1] = Convert.ToInt32(input[1]);
            }
            return output;
        } 

        static void BubbleSort(ref int[,] input)
        {
            int n;
            for (int j = 0; j < input.GetLength(0); j++)
            {
                for (int i = 0; i < input.GetLength(0) - 1; i++)
                {
                    if (input[i, 0] > input[i + 1, 0])
                    {
                        n = input[i + 1, 0];
                        input[i + 1, 0] = input[i, 0];
                        input[i, 0] = n;
                        n = input[i + 1, 1];
                        input[i + 1, 1] = input[i, 1];
                        input[i, 1] = n;
                    }
                }
            }
            
        }

        static int Vasyata(int[,] input)
        {
            int vasyata = 0;
            int max = 0;
            BubbleSort(ref input);
            for (int i = 0; i < input.GetLength(0) - 1; i++)
            {
                if (input[i, 0] == input[i + 1, 0])
                {
                    if (input[i, 1] > max)
                    {
                        max = input[i, 1];
                    }
                }
                else
                {
                    if (input[i, 1] > max)
                    {
                        max = input[i, 1];
                    }
                    vasyata = vasyata + max;
                    max = 0;
                }
            }
            return vasyata;
        }

        static void Main(string[] args)
        {
            int[,] newmas = Input(3);
            Console.WriteLine(Vasyata(newmas));
            Console.ReadKey();
        }
    }
}