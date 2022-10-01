using System;

namespace Repo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string str;
            Console.WriteLine(" Введите год");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            if (a % 4 == 0)
            {
                Console.WriteLine(" Високосный год");
            }
            else
            {
                Console.WriteLine(" Не високосный год");
            }
            

        }
    }
}
