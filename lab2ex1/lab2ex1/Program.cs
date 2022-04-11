using System;
class program
{
    static void Main()
    {
        Console.Write("Введiть номер знака зодiака: ");
        int num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Овен");
                break;
            case 2:
                Console.WriteLine("Телець");
                break;
            case 3:
                Console.WriteLine("Близнюки");
                break;
            case 4:
                Console.WriteLine("Рак");
                break;
            case 5:
                Console.WriteLine("Лев");
                break;
            case 6:
                Console.WriteLine("Дiва");
                break;
            case 7:
                Console.WriteLine("Терези");
                break;
            case 8:
                Console.WriteLine("Скорпiон");
                break;
            case 9:
                Console.WriteLine("Стрiлець");
                break;
            case 10:
                Console.WriteLine("Козерiг");
                break;
            case 11:
                Console.WriteLine("Водолiй");
                break;
            case 12:
                Console.WriteLine("Риби");
                break;

            default: Console.WriteLine("Ви ввели неправильну цифру ");
                break;
        }
    }
}