using System;
using System.Collections.Generic;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}\n");
        Console.WriteLine($"Entry: {_entryText}\n\n");
    }
}