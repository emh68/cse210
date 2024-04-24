using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage (i.e. 50, 80, etc.)? ");
        string gradePercentage = Console.ReadLine();
        int num = int.Parse(gradePercentage);

        if (num >= 90)
        {
            Console.Write("Your grade in the class is an A.");
        }

        else if (num >= 80)
        {
            Console.Write("Your grade in the class is an B.");
        }

        else if (num >= 70)
        {
            Console.Write("Your grade in the class is an C.");
        }

        else if (num >= 60)
        {
            Console.Write("Your grade in the class is an D.");
        }

        else
        {
            Console.Write("Your grade in the class is an F.");
        }

        if (num >= 70)
        {
            Console.Write("Congratulations, you passed the class!");
        }

        else
        {
            Console.Write("It's ok, you'll do better next time.")
        }
    }
}
