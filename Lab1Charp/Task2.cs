using System;

namespace lab1
{
    public class Task2
    {
        public static bool IsSumOfDigitsOdd(int number)
        {
            // Беремо число по модулю, щоб код працював і для від'ємних чисел 
            int absNumber = Math.Abs(number);
            
            // Перевіряємо, чи число дійсно двозначне
            if (absNumber < 10 || absNumber > 99)
            {
                throw new ArgumentException("Помилка: Число має бути двозначним.");
            }

            // Знаходимо суму цифр (десятки + одиниці)
            int sum = (absNumber / 10) + (absNumber % 10);
            
            // Якщо залишок від ділення на 2 не дорівнює нулю - сума непарна
            return sum % 2 != 0;
        }

        public static void Execute()
        {
            Console.Write("Завдання 2.10. Введіть двозначне число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                try
                {
                    bool result = IsSumOfDigitsOdd(number);
                    Console.WriteLine(result ? "Сума цифр НЕПАРНА." : "Сума цифр ПАРНА.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Помилка вводу: це не ціле число.");
            }
        }
    }
}
