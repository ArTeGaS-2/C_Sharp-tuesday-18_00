using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВТ_C__18_00
{
    internal class Guess_the_num
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Змінна класу Random
            Random random = new Random();

            // Змінна типу int, зберігає випадкове число
            // створене класом Random
            int secretNumber = random.Next(1, 101);

            Console.WriteLine("Введіть число від 1 до 100: \n");
            // Змінна, що зберігає результат введення у вигляді
            // цілого числа

            int guess = 0;

            int attempts = 0;

            while (guess != secretNumber)
            {
                guess = int.Parse(Console.ReadLine());

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Загадане число більше!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Загадане число меньше!");
                }
                else
                {
                    Console.WriteLine(
                        $"Вітаю, ви виграли за {attempts} спроб!");
                }
            }
        }
    }
}
