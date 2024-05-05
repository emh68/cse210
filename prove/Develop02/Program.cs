using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        bool quit = false;

        while (!quit)
        {

            Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine(promptGenerator.GetRandomPrompt());
                Console.ReadLine();
                journal.AddEntry();
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the filename? ");
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the filename? ");
            }

            else if (choice == "5")
            {
                quit = true;
            }
        }

    }
}
