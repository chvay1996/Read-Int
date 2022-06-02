using System;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertNumber();
        }
        static void ConvertNumber()
        {
            int namber;
            Console.Write("Введите число: ");
            bool shouldStartConverting = true;

            while (shouldStartConverting)
            {
                string line = Console.ReadLine();
                bool tryParse = int.TryParse(line, out namber);

                if (tryParse)
                {
                    Console.WriteLine($"Вы ввели верное число {namber}");
                    shouldStartConverting = false;
                }
                else
                {
                    Console.WriteLine($"Вы ввели не число, введите еще раз");
                }

            }
        }
    }
}
/*Задача:
Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine() ) и пытается сконвертировать его в тип int (с помощью int.TryParse())
Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно. После ввода, который удалось преобразовать в число, число возвращается.
P.S Задача решается с помощью циклов
P.S Также в TryParse используется модфикатор параметра out*/