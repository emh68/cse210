using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Genesis", 1, 1, 5);
        Console.WriteLine(reference1.GetDisplayText());
    }
}