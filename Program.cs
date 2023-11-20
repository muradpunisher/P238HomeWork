// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Məsələ bir: [ İnput olaraq ilin aylarının hər hansı biri daxil edilir, mən consola hansı fəsil olduğunu yazdırmalıyam. Yanlış ay adı daxil edilərsə ekrana yazdırmalıyam ki, yanlış ad daxil etdiniz.]
        Console.WriteLine("Enter a month name:");
        string month = Console.ReadLine().ToLower();

        if (month == "december" || month == "january" || month == "february")
        {
            Console.WriteLine("Winter");
        }
        else if (month == "march" || month == "april" || month == "may")
        {
            Console.WriteLine("Spring");
        }
        else if (month == "june" || month == "july" || month == "august")
        {
            Console.WriteLine("Summer");
        }
        else if (month == "september" || month == "october" || month == "november")
        {
            Console.WriteLine("Autumn");
        }
        else
        {
            Console.WriteLine("You have entered the wrong month name.");
        }

        // Məsələ iki: (İnput olaraq integr bir dəyər gəlir mən bu ədədin neçə mərtəbəli olduğunu consola yazdırmalıyam.)
        Console.WriteLine("Enter an integer value to determine the number of floors:");
        int number = Convert.ToInt32(Console.ReadLine());

        int floorCount = 1;
        while (number >= 10)
        {
            number /= 10;
            floorCount++;
        }
        Console.WriteLine($"The number of floors is: {floorCount}");

        // Məsələ üç: {Daxil edilən ədədin faktorialını tap. (3!=3*2*1)}
        Console.WriteLine("Enter a number to find its factorial:");
        int factorialNumber = Convert.ToInt32(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= factorialNumber; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"The factorial of {factorialNumber} is: {factorial}");

        Console.ReadKey();
    }
}
