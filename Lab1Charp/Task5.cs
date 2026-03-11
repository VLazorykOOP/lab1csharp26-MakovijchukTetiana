using System;

namespace lab1
{
    public class Task5
    {
        public static int SquareOfSum(int a, int b)
        {
            // Знаходимо суму
            int sum = a + b;
            
            // Підносимо у квадрат (множимо число саме на себе)
            return sum * sum;
        }

        public static void Execute()
        {
            Console.WriteLine("Завдання 5.10. Піднесення у квадрат суми двох цілих чисел.");
            
            Console.Write("Введіть перше ціле число a: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Помилка: введіть коректне ціле число.");
                return;
            }
            
            Console.Write("Введіть друге ціле число b: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Помилка: введіть коректне ціле число.");
                return;
            }

            int result = SquareOfSum(a, b);
            Console.WriteLine($"({a} + {b})^2 = {result}");
        }
    }
}
