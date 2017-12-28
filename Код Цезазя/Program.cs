using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Цезазя
{// вводится строока, каждый символ меняется на +3 и +позиция в слове
    class Program
    {

        static string Cezar(string input)
        {
            string[] words = input.Split(' ');
            string output = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (char.IsLower(words[i][j]))
                    {
                        output = output + (char)(((int)words[i][j] + 4 + j - (int)'a') % 26 + (int)'a');
                    }
                    else if (char.IsUpper(words[i][j]))
                    {
                        output = output + (char)(((int)words[i][j] + 4 + j - (int)'A') % 26 + (int)'A');
                    }
                    else
                    {
                        output = output + words[i][j];
                    }
                }
                output = output + " ";
            }
            return output;
        }

        static void Main(string[] args)
        {
            string output = Cezar(Console.ReadLine());
            Console.Write(output);
            Console.ReadKey();
        }
    }
}
