using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Genesis", 1, 1, 5);
        Scripture scripture = new Scripture(reference1, "In the beginning God created the heavens and the earth");

        Console.WriteLine(scripture.GetDisplayText());

        string input;
        do
        {
            Console.WriteLine("Press enter to hide words or type 'quit' to exit the program:");
            input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(scripture.IsCompletelyHidden());

        } while (true);
    }
}
