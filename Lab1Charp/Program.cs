using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування 
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool keepRunning = true;

            while (keepRunning)
            {
                // Виводимо красиве меню
               
                Console.WriteLine("         Лабораторна робота №1");
                Console.WriteLine("Оберіть завдання для перевірки:");
                Console.WriteLine("1. Завдання 1.10 (Ребро куба)");
                Console.WriteLine("2. Завдання 2.10 (Сума цифр двозначного числа)");
                Console.WriteLine("3. Завдання 3.10 (Точка в області)");
                Console.WriteLine("4. Завдання 4.10 (Пошук невідомої дати)");
                Console.WriteLine("5. Завдання 5.10 (Квадрат суми двох чисел)");
                Console.WriteLine("6. Завдання 6.10 (Обчислення виразу)");
                Console.WriteLine("0. Вихід з програми");
               
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();
                Console.WriteLine(); 

                // Викликаємо метод Execute() відповідного класу залежно від вибору
                switch (choice)
                {
                    case "1":
                        Task1.Execute();
                        break;
                    case "2":
                        Task2.Execute();
                        break;
                    case "3":
                        Task3.Execute();
                        break;
                    case "4":
                        Task4.Execute();
                        break;
                    case "5":
                        Task5.Execute();
                        break;
                    case "6":
                        Task6.Execute();
                        break;
                    case "0":
                        keepRunning = false;
                        Console.WriteLine("Дякую за використання програми. До побачення!");
                        break;
                    default:
                        Console.WriteLine("Невідомий вибір. Будь ласка, введіть число від 0 до 6.");
                        break;
                }

                // Затримка екрану перед поверненням до головного меню
                if (keepRunning)
                {
                    Console.WriteLine("\nНатисніть будь-яку клавішу для повернення в меню...");
                    Console.ReadKey();
                    Console.Clear(); // Очищуємо консоль
                }
            }
        }
    }
}
