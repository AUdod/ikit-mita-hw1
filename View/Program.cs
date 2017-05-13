using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace View
{
    class Program
    {
        static void PrintCatName(Cat cat)
        {
            Console.Write(cat.Name, Console.ForegroundColor = cat.Color);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PrintCatMenu(Cat cat)
        {
            Console.Write("\nМеню для ");
            PrintCatName(cat);
            Console.WriteLine("\n1: вывести имя кота\n2: покормить кота \n3: наказать кота\n4: узнать дату рождения \n5,e,exit: выйти из программы");
        }

        static void Main(string[] args)
        {
            Cat cat = new Cat();

            Console.Write("Введите имя кота: ");
            cat.Name = Console.ReadLine();

            Console.Write("Поздравляем вас с покупкой ");
            PrintCatName(cat);

            bool exit = true;
            while (exit)
            {
                PrintCatMenu(cat);

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        PrintCatName(cat);
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.Clear();
                        cat.Feed();
                        PrintCatName(cat);
                        Console.WriteLine(": mrrrr~r~r~");
                        break;

                    case "3":
                        Console.Clear();
                        cat.Punish();
                        PrintCatName(cat);
                        Console.WriteLine(": sh-h-h-h");
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(cat.Age.ToShortDateString());
                        break;

                    case "5":
                    case "exit":
                    case "e":
                        exit = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Вы ввели значение, не соответствующее пунктам меню. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
