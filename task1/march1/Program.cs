using System;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.WriteLine("Задача 1:");
            int a1, b1;

            Console.WriteLine("Введите первое число: ");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ответ:");
            if (a1 == b1)
            {
                Console.WriteLine("Равны");
            }
            else if (a1 > b1)
            {
                Console.WriteLine("Первое число больше");
            }
            else
            {
                Console.WriteLine("Второе число больше");
            }

            //Задание 2
            Console.WriteLine("\nЗадача 2:");
            int a2;
            Console.WriteLine("Введите число:");

            a2 = int.Parse(Console.ReadLine());
            if (5 < a2 && a2 < 10)
            {
                Console.WriteLine("Число ,больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }

            //Задание 3
            Console.WriteLine("\nЗадача 3");
            int a3;
            Console.WriteLine("Введите число:");
            a3 = int.Parse(Console.ReadLine());
            if (a3 == 5 || a3 == 10)
            {
                Console.WriteLine("Число равно 5 или 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }

            //Задание 4
            Console.WriteLine("\nЗадача 4");

            double bank;

            bank = double.Parse(Console.ReadLine());

            if (bank < 100)
            {
                bank *= 1.07;
            }
            else if (bank >= 100 && bank < 200)
            {
                bank *= 1.09;

            }
            else
            {
                bank *= 1.12;
            }
            Console.WriteLine(bank);

            //Задание 5
            Console.WriteLine("\nЗадача 5");

            bank += 15;

            Console.WriteLine(bank);
        }
    }
}