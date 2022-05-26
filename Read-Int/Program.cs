using System;

namespace ReadInt
{
    class Program
    {
        static void ConvertNumber()
        {
            int namber = 0;
            Console.Write("Введите число: ");
            bool check = true;

            while (check)
            {
                string line = Console.ReadLine();
                if (int.TryParse(line, out namber))
                {
                    Console.WriteLine($"Вы ввели верное число {namber}");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"Вы ввели не число, введите еще раз");
                }

            }
        }
        static void Main(string[] args)
        {
            ConvertNumber();
        }
    }
}
/*Задача:
Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine() ) и пытается сконвертировать его в тип int (с помощью int.TryParse())
Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно. После ввода, который удалось преобразовать в число, число возвращается.
P.S Задача решается с помощью циклов
P.S Также в TryParse используется модфикатор параметра out*/