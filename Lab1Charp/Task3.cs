using System;

namespace lab1
{
    public class Task3
    {
        public static string GetPointLocation(double x, double y)
        {
            // Верхня та бічні межі задаються графіком y = -|x|
            double borderY = -Math.Abs(x);

            // Перевірка, чи точка строго всередині:
            // Вона має бути нижче графіка y = -|x| ТА вище лінії y = -100
            if (y < borderY && y > -100)
            {
                return "Так";
            }
            
            // Перевірка, чи точка лежить точно на межі:
            // 1. На бічних лініях y = -|x| (але не нижче y = -100)
            // 2. На нижній лінії y = -100 (в межах від x = -100 до x = 100)
            if ((y == borderY && y >= -100) || (y == -100 && x >= -100 && x <= 100))
            {
                return "На межі";
            }
            
            // Якщо жодна з умов не виконалася, точка знаходиться зовні
            return "Ні";
        }

        public static void Execute()
        {
            Console.WriteLine("Завдання 3.10. Перевірка потрапляння точки в область.");
            
            Console.Write("Введіть координату x: ");
            if (!double.TryParse(Console.ReadLine(), out double x)) return;
            
            Console.Write("Введіть координату y: ");
            if (!double.TryParse(Console.ReadLine(), out double y)) return;

            string result = GetPointLocation(x, y);
            Console.WriteLine($"Результат: {result}");
        }
    }
}
