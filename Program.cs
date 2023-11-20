// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Məsələ bir: [input olaraq ilin aylarının hər hansı biri daxil edilir, mən consola hansı fəsil olduğunu yazdırmalıyam]
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

    }
}

