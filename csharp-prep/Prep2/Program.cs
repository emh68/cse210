using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage (i.e. 50, 80, etc.)? ");
        string gradePercentage = Console.ReadLine();
        int num = int.Parse(gradePercentage);
        string letter = String.Empty;
        string sign = String.Empty;

        if (num >= 90)
        {
            letter = "A";
        }

        else if (num >= 80)
        {
            letter = "B";
        }

        else if (num >= 70)
        {
            letter = "C";
        }

        else if (num >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if (num % 10 >= 7 && !(num >= 97 || num < 60))
        {
            sign = "+";
        }

        else if (num % 10 < 3 && !(num < 60))
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade in the class is a {letter}{sign}. ");


        if (num >= 70)
        {
            Console.Write("Congratulations, you passed the class! ");
        }

        else
        {
            Console.Write("It's ok, you'll do better next time. ");
        }
    }
}
