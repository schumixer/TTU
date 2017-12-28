using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * учитывать количество очков
 * сделать сектор приз, банкрот, х2, х3
 * вывод очков
 * выгружать слова из файла
 * каждому слову прилагать вопрос
 * мелкие недочеты
 * случай, когда буква уже есть и когда вводится не буква
 */ 
namespace Поле_чудец
{
    class Program
    {
        static bool Slovocheck(char[] answer)
        {
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == '*')
                {
                    return false;
                }
            }
            return true;
        }

        static void Game(string slovo)
        {
            int put = 0;
            Random rand = new Random();
            int go = 0;
            bool check = false;
            string[] players = new string[3];
            int[] score = new int[3] { 0, 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Имя игрока №{0}: ", i + 1);
                players[i] = Console.ReadLine();
            }
            char[] answer = new char[slovo.Length];
            char letter;
            for (int i = 0; i < slovo.Length; i++)
            {
                answer[i] = '*';
            }
            while (Slovocheck(answer) != true)
            {
                check = false;
                Console.WriteLine("Ход игрока " + players[go]);
                letter = Console.ReadKey().KeyChar;
                Console.Write("\nСлово: ");
                for (int i = 0; i < slovo.Length; i++)
                {
                    if (slovo[i] == letter)
                    {
                        answer[i] = letter;
                        check = true;
                    }
                }

                if (check == true)
                {
                    put = rand.Next(1, 10) * 100;
                    Console.Write("На барабане {0} очков\n", put);
                    score[go] = score[go] + put;
                }
                else
                {
                    go++;
                }
                if (go == 3)
                {
                    go = 0;
                }
                for (int i = 0; i < slovo.Length; i++)
                {
                    Console.Write(answer[i]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        { 
            string slovo = Console.ReadLine();
            Console.Clear();
            Game(slovo);

            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1,2));
            
            Console.ReadKey();
        }
    }
}
