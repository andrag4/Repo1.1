using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 0;
            string str;
            Console.WriteLine(" Напишите год ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            if ((a % 4 == 0) & (a % 100 != 0) | (a % 400 == 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Високосный год");
            }
            else
            {
                Console.WriteLine(" Не високосный год");
            }
        }
    }
}