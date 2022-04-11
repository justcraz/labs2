using System;
class Type2
{

    public static void Main()
    {
        double a = -Math.PI / 2;
        double b = 3*Math.PI / 2;
        double dx = Math.PI / 3;
        while (true)
        {

            Console.Write("Виберiть дiю: \n" +
                    "1 - Обчислiть за допомогою циклу з передумовою \n" +
                    "2 - Обчислiть за допомогою циклу з пiсляумовою \n" +
                    "3 - Вийти з програми \n" +
                    "Ваш вибiр: ");
            int str = int.Parse(Console.ReadLine());
            double x, y = 0;
            if (str == 1)
            {//Цикл з передумовою
                x = a;
                Console.Write("|  x      |   y=f(x)  |\n");
                while (x <= b)
                {
                    Console.Write("|{0:F3}    |    {1,5:F2}  |\n", x, y);
                    x += dx;
                    y = Math.Pow(Math.Cos(x), 2) + 3 * Math.Sin(x);
                }
            }
            if (str == 2)
            {//Цикл з пiсляумовою
                x = a;
                Console.Write("|  x      |   y=f(x)  |\n");
                do
                {
                    Console.Write("|{0:F3}    |    {0,5:F2}  |\n", x, y);
                    x += dx;
                    y = Math.Pow(Math.Cos(x),2) + 3*Math.Sin(x);
                } while (x <= b);
            }
            if (str == 3)
            {
                break;
            }
            else
                if (str < 1 || str > 3)
                continue;
        }
    }
}