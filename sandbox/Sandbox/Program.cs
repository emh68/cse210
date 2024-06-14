


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

// using System.Collections.Generic;

// List<string> words = new List<string> {"camera", "apple", "mouse", "keyboard"};

// Console.WriteLine(words.Count);

// for (int i = 0; i < words.Count; i++)
// {
//     Console.WriteLine(words[i]);
// }

// using System;

// public class Program
// {
//     static void Main()
//     {
//         Student student = new Student("Brigham", "234");
//         string name = student.GetName();
//         string number = student.GetNumber();
//         Console.WriteLine(name);
//         Console.WriteLine(number);
//     }

// }

// public class Person
// {
//     private string _name;

//     public Person(string name)
//     {
//         _name = name;
//     }

//     public string GetName()
//     {
//         return _name;
//     }
// }

// public class Student : Person
// {
//     private string _number;

//     public Student(string name, string number) : base(name)
//     {
//         _number = number;
//     }

//     public string GetNumber()
//     {
//         return _number;
//     }

//     public string GetStudentInfo()
//     {
//         return _name + " " + _number;
//     }
// }

using System;

namespace library_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetAuthor("Smith");
            book1.SetTitle("A Great Book");

            PictureBook book2 = new PictureBook();
            book2.SetAuthor("Jones");
            book2.SetTitle("Wonderful Picture Book");
            book2.SetIllustrator("Mark Roberts");

            Console.WriteLine(book1.GetBookInfo());
            Console.WriteLine(book2.GetBookInfo());
        }
    }


    public class Book
    {
        private string _author = "";
        private string _title = "";

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public virtual string GetBookInfo()
        {
            return $"{_title} by {_author}";
        }
    }
    public class PictureBook : Book
    {
        private string _illustrator = "";

        public string GetIllustrator()
        {
            return _illustrator;
        }

        public void SetIllustrator(string illustrator)
        {
            _illustrator = illustrator;
        }
        public override string GetBookInfo()
        {
            return $"{GetTitle()} by {GetAuthor()}, illustrated by {_illustrator}";
        }
    }
}



