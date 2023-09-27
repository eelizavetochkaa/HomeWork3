using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1,4.2 \n Программа читает с экрана номер дня в году и переводит этот число в месяц и день месяца");
            Console.WriteLine("Введите номер дня в году");
            int n = int.Parse(Console.ReadLine());
            DateTime date = Convert.ToDateTime("01.01.1999");

            if ((n>365) || (n<=0))
            {
                Console.WriteLine("Столько дней в году не бывает, нужно было ввести число от 1 до 365");
            }
            else
            {
                date = date.AddDays(n - 1);
                Console.WriteLine(date.ToString("d MMMM"));
            }

            Console.WriteLine("Домашнее задание 4.1");
            Console.WriteLine("Программа читает с экрана номер дня в году и переводит этот число в месяц и день месяца, а также определяет, високосный год или нет");
            Console.WriteLine("Введите номер дня в году");

            int x = int.Parse(Console.ReadLine());
            DateTime date1 = Convert.ToDateTime("01.01.1999");
            Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Год високосный");
                if ((x > 366) || (x <= 0))
                {
                    Console.WriteLine("Столько дней в году не бывает, нужно было ввести число от 1 до 366");
                }
                else
                {
                    date1 = date1.AddDays(x - 1);
                    Console.WriteLine(date1.ToString("d MMMM") + " " + year + " года");
                }
            }
            else
            {
                Console.WriteLine("Год невисокосный");
                if ((x > 366) || (x <= 0))
                {
                    Console.WriteLine("Столько дней в году не бывает, нужно было ввести число от 1 до 366");
                }
                else
                {
                    date1 = date1.AddDays(x - 1);
                    Console.WriteLine(date1.ToString("d MMMM") + " " + year + " года");
                }
            }
            Console.ReadKey();
        }
    }
}
