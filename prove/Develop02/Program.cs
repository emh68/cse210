using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Console.WriteLine(promptGenerator.GetRandomPrompt());

        Journal journal = new Journal();
        journal.AddEntry();
        journal.DisplayAll();
    }
}
