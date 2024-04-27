using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SquareNumber(number);
        DisplayResult(name, numberSquared);
    }

    // Function display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    // Function prompt for user name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function prompt for user favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function square the user favorite number
    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    // Function display results
    static void DisplayResult(string name, int numberSquared)
    {
        Console.Write($"{name}, the square of your number is {numberSquared}");
    }
}