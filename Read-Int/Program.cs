using System;

namespace ReadInt
{
    class Program
    {
        static int ConvertNumber(int namber)
        {
            string line;
            bool check = false;

            while (check == false)
            {
                line = Console.ReadLine();
                check = int.TryParse(line, out namber);
                Console.WriteLine($"Вы ввели верное число {namber}");
            }
            return namber;
        }
        static void Main(string[] args)
        {
            int namber = 0;
            Console.Write("Введите число: ");

            ConvertNumber(namber);
        }
    }
}
/*Задача:
Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine() ) и пытается сконвертировать его в тип int (с помощью int.TryParse())
Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно. После ввода, который удалось преобразовать в число, число возвращается.
P.S Задача решается с помощью циклов
P.S Также в TryParse используется модфикатор параметра out*/