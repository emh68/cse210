using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scriptures.json");
        string jsonString = File.ReadAllText(jsonFilePath);
        var scriptureData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(jsonString);

        Console.WriteLine("Enter the book name (i.e. Genesis, Exodus): ");
        string book = Console.ReadLine();

        Console.WriteLine("Enter the chapter number: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the verse or verses (i.e. 1 or 1-5): ");
        string verseInput = Console.ReadLine();

        int startVerse = 0;
        int endVerse = -1;

        var verses = verseInput.Split('-');
        startVerse = int.Parse(verses[0]);
        if (verses.Length > 1)
        {
            endVerse = int.Parse(verses[1]);
        }

        string scriptureText = GetScriptureText(scriptureData, book, chapter, startVerse, endVerse);

        if (scriptureText != null)
        {
            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            Scripture scripture = new Scripture(reference, scriptureText);

            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());

            string input;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to hide words or type 'quit' to exit the program:");
                input = Console.ReadLine();

                if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
                {
                    break;
                }

                scripture.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

            } while (true);
        }
        else
        {
            Console.WriteLine("The specified scripture was not found.");
        }
    }

    static string GetScriptureText(Dictionary<string, Dictionary<string, Dictionary<string, string>>> scriptureData, string book, int chapter, int startVerse, int endVerse)
    {
        List<string> verseTexts = new List<string>();
        for (int i = startVerse; i <= (endVerse == -1 ? startVerse : endVerse); i++)
        {
            verseTexts.Add(scriptureData[book][chapter.ToString()][i.ToString()]);
        }
        return string.Join(" ", verseTexts);
    }
}
