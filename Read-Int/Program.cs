using System;

namespace ReadInt
{
    class Program
    {
        static int TryParse(string line, out int namber)
        {
            while (true)
            {
                line = Console.ReadLine();
                int.TryParse(line, out namber);

                if (namber == 5)
                {
                    Console.WriteLine($"Вы ввели верное число {namber}");
                    return namber;
                }
                else
                {
                    Console.WriteLine("Вы ввели не верное число!");
                    Console.Write("Попробуйте заново: ");
                }
            }
        }
        static void Main(string[] args)
        {
            string line = ""; 
            int namber = 0;
            Console.Write("Введите число: ");

            TryParse(line, out namber);
        }
    }
}
/*Задача:
Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine() ) и пытается сконвертировать его в тип int (с помощью int.TryParse())
Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно. После ввода, который удалось преобразовать в число, число возвращается.
P.S Задача решается с помощью циклов
P.S Также в TryParse используется модфикатор параметра out*/