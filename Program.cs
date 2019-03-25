using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            // #1
            //int spaces = 0;
            //ConsoleKeyInfo Dote;
            //Console.WriteLine("Напишите предложение, для окончания ввода напишите точку(.)");
            //do
            //{
            //    Dote = Console.ReadKey();
            //    if (Dote.KeyChar == ' ')
            //    {
            //        spaces++;
            //    }

            //    if (Dote.KeyChar == '.')
            //    {
            //        break;
            //    }
            //}

            //while (true);
            //{
            //    Console.WriteLine("Spaces = " + spaces);
            //}
            //Console.ReadKey();

            ///////////////////////////////////////////////////////////////////

            // #5
            //Console.WriteLine("введите 3-х значное число");
            //string Number = Console.ReadLine();
            //Convert.ToInt32(Number);
            //for (int i = Number.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(Number[i]);
            //}
            //Console.ReadKey();

            ///////////////////////////////////////////////////////////////////

            //Console.WriteLine("введите число А и Б (А<Б)");

            // #4
            //Console.WriteLine("Number A");
            ////string NumberA = Console.ReadLine();
            ////Convert.ToInt32(NumberA);
            //int NumberA = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Number B");
            ////string B = Console.ReadLine();
            ////Convert.ToInt32(B);
            //int NumberB = Convert.ToInt32(Console.ReadLine());

            //for (int i = NumberA; i <= NumberB; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            ///////////////////////////////////////////////////////////////////

            //#2
            Console.WriteLine("Введите 6-значное число");
            string ticket = Console.ReadLine();
            if ((ticket[0] + ticket[1]) + ticket[2] == (ticket[3] + ticket[4]) + ticket[5])
            {
                Console.WriteLine("Билет счастливый");
            }
            else
            {
                Console.WriteLine("Билет не является счастливым");
            }
            Console.ReadKey();
        }

    }
}
