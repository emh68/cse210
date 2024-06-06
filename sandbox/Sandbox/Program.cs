


// using System;
// using System.IO;

// class Program
// {
//     static void Main(string[] args)
//     {

//         string fileName = "myFile.txt";

//         using (StreamWriter outputFile = new StreamWriter(fileName))
//         {
//             // You can add text to the file with the WriteLine method
//             outputFile.WriteLine("This will be the first line in the file.");

//             // You can use the $ and include variables just like with Console.WriteLine
//             string color = "Blue";
//             outputFile.WriteLine($"My favorite color is {color}");

//         }
//     }
// }

// using System;


// class Program
// {
//     static void Main(string[] args)
//     {
//         Person p1 = new Person(); // Don't pass any information to get the default values
//         Person p2 = new Person("Jane", "Doe"); // pass the first and last names
//         Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables

//         Console.WriteLine($"{p3._title} {p3._firstName} {p3._lastName}");
//         // Console.WriteLine(p2);
//         // Console.WriteLine(p3);
//     }
// }

// using System;


// class Program
// {
//     static void Main(string[] args)
//     {

//     }

// }

using System.Collections.Generic;

List<string> words = new List<string> {"camera", "apple", "mouse", "keyboard"};

Console.WriteLine(words.Count);

for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}
