using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_3
{
    enum weekday
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 1 \n Программа определяет, является ли последовательность упорядочненной по возрастанию");
            int[] sequence = new int[10];
            bool ordered = true;
            int index = -1;

            Console.WriteLine("Введите последовательность из 10 чисел:");

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.WriteLine("Число {0}: ", i + 1);
                sequence[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    ordered = false;
                    index = i + 2;
                    break;
                }
            }

            if (ordered)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine("Последовательность не упорядочена по возрастанию. Нарушение на позиции " + index);
            }


            Console.WriteLine("Номер 2 \n Программа определяет достоинство соответствующей карты");
            int n;
            try
            {
                Console.WriteLine("Введите номер карты от 6 до 14");
                n = int.Parse(Console.ReadLine());

                string rank;
                if (n >= 6 && n <= 10)
                {
                    rank = n.ToString();
                }
                else if (n == 11)
                {
                    rank = "валет";
                }
                else if (n == 12)
                {
                    rank = "дама";
                }
                else if (n == 13)
                {
                    rank = "король";
                }
                else if (n == 14)
                {
                    rank = "туз";
                }
                else
                {
                    throw new Exception("Нужно было ввести номер карты от 6 до 14");
                }
                Console.WriteLine($"Достоинство карты номера {n} = {rank}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
            Console.WriteLine("Номер 3 \n Программа выводит значения в соответствии с таблицей");
            Console.WriteLine("Введите jabroni/school counselor/programmer/bike gang member/politician/rapper/");
            string a = Console.ReadLine();
            a = a.ToLower();
            switch (a)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal"); 
                    break;
                default: Console.WriteLine("Beer"); 
                    break;

            }

            Console.WriteLine("Номер 4 \n Программа выводит названия дня недели в зависимости от введённого порядкового номера \n Введите порядковый номер дня недели от 1 до 7");
            int number = int.Parse(Console.ReadLine());
            if (number >=1 && number <=7)
            {
                weekday day = (weekday)number;
                Console.WriteLine(day);
            }
            else
            {
                Console.WriteLine("Нужно было ввести порядковый номер дня недели от 1 до 7");
            }

            Console.WriteLine("Номер 5 \n Программа обходит весь массив и при встречи элементов HelloKitty и Barbie doll считает их количество");
            string[] toys = { "Hello Kitty", "Barbie doll", "Teddy", "Hello Kitty" , "LOL", "Furby"};

            int quantity = 0;
            foreach (string dolls in toys)
            {
                if (dolls == "Hello Kitty" || dolls == "Barbie doll")
                {
                    quantity++;
                }
            }

            Console.WriteLine($"Количество кукол в сумке = {quantity}");

            Console.ReadKey();
        }
    }
}
