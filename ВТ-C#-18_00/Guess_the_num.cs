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

            string playAgain = "так";

            while (playAgain.ToLower() == "так")
            {
                playAgain = Console.ReadLine();
                MainGameCycle();
            }
        }
        public static void MainGameCycle()
        {
            // Змінна класу Random
            Random random = new Random();

            // Змінна типу int, зберігає випадкове число
            // створене класом Random
            int secretNumber = random.Next(1, 101);

            Console.WriteLine("Введіть число від 1 до 100.");
            // Змінна, що зберігає результат введення у вигляді
            // цілого числа

            int guess = 0;

            int attempts = 0;

            int maxAttempts = 10;

            int maxAttemptsIndicator = maxAttempts;

            Console.WriteLine(
                    $"Максимальна кількість спроб - {maxAttempts} \n");

            while (guess != secretNumber & attempts < maxAttempts)
            {
                guess = int.Parse(Console.ReadLine());

                attempts++;
                maxAttemptsIndicator--;

                if (guess < secretNumber)
                {
                    Console.WriteLine(
                        $"Загадане число більше! Поточна спроба {attempts}. " +
                        $"Залишилось {maxAttemptsIndicator} спроб.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine(
                        $"Загадане число меньше! Поточна спроба {attempts}." +
                        $"Залишилось {maxAttemptsIndicator} спроб.");
                }
                else
                {
                    Console.WriteLine(
                        $"Вітаю, ви виграли за {attempts} спроб!");
                }
            }
            if (attempts == maxAttempts && guess != secretNumber)
            {
                Console.WriteLine(
                    $"Вітаю ви програли! Загадане число {secretNumber}.");
            }
        }
    }
}
