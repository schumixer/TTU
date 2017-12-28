using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ClassExample
{

    class Program
    {
        public static string SevenAteNine(string str)
        {
            string mas = "";
            mas = mas + str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (i != str.Length - 1 && str[i - 1] == '7' && str[i] == '9' && str[i + 1] == '7')
                {

                }
                else
                {
                    mas = mas + str[i];
                }
            }
            return mas;
        }

        static void Main(string[] args)
        {
           Console.WriteLine(SevenAteNine("79765863975797978"));
            Console.ReadKey();
        } 
    }
}
