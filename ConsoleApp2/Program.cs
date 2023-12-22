internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            bool start = true;
            int b = 3;
            int randomNum = new Random().Next(0, 11);
            messageColor($"Отгадайте число от 0 до 10!\nУ вас всего {b} попытки\n", Console.ForegroundColor);
            messageColor("\n> ", ConsoleColor.DarkGray);
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice < 0 || choice > 10)
            {
                messageColor("\nТы ввёл недопустимое число!", ConsoleColor.Red);
                return;
            }

            while (start == true)
            {
                if (choice == randomNum)
                {
                    messageColor($"\nВы выиграли! Число было {randomNum}", ConsoleColor.Green);
                    start = false;
                    break;
                }
                if (b == 1)
                {
                    messageColor($"\nВы проиграли :( Число было {randomNum}", ConsoleColor.Red);
                    break;
                }
                else
                {
                    Console.WriteLine($"\nВы не угадали( Осталось попыток: {--b}");
                }
                messageColor("\n> ", ConsoleColor.DarkGray);
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 0 || choice > 10)
                {
                    messageColor("\nТы ввёл недопустимое число!", ConsoleColor.Red);
                    return;
                }
            }
        }
        catch (Exception)
        {
            messageColor("\nНекорректное значение!", ConsoleColor.Red);
            return;
        }
    }

    public static void messageColor(string asd, ConsoleColor dsa)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        Console.ForegroundColor = dsa;
        Console.Write(asd);
        Console.ForegroundColor = defaultColor;
    }


}