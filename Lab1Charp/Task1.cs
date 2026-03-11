using System;

namespace lab1
{
    public class Task1
    {
        public static double GetCubeEdge(double volume)
        {
            return Math.Cbrt(volume);
        }

        public static void Execute()
        {
            Console.Write("Завдання 1.10. Введіть об'єм куба v: ");
            if (double.TryParse(Console.ReadLine(), out double v) && v >= 0)
            {
                Console.WriteLine($"Ребро куба: {GetCubeEdge(v):F4}");
            }
            else
            {
                Console.WriteLine("Помилка: введіть коректне додатне число.");
            }
        }
    }
}
