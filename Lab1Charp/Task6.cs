using System;

namespace lab1
{
    public class Task6
    {
        public static double CalculateExpression(double a, double b)
        {
            // Перевіряємо ділення на нуль у другому дробі (a + b)
            if (a + b == 0)
            {
                throw new DivideByZeroException("Сума a та b дорівнює нулю, ділення на нуль неможливе.");
            }

            // Обчислюємо перший дріб: b / (b^2 + 1)
            double term1 = b / (b * b + 1.0);
            
            // Обчислюємо другий дріб: (a - b) / (a + b)
            double term2 = (a - b) / (a + b);

            // Збираємо весь вираз разом
            return 5.0 + term1 + term2;
        }

        public static void Execute()
        {
            Console.WriteLine("Завдання 6.10. Обчислення виразу.");
            
            Console.Write("Введіть дійсне число a: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Помилка вводу.");
                return;
            }
            
            Console.Write("Введіть дійсне число b: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Помилка вводу.");
                return;
            }

            try
            {
                double result = CalculateExpression(a, b);
                Console.WriteLine($"Результат: {result:F4}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
