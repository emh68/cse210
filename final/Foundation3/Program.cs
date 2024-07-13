using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "10001");
        Address address2 = new Address("426 Elm St", "San Francisco", "CA", "94101");
        Address address3 = new Address("789 Oak St", "Chicago", "IL", "60601");

        Lecture lecture = new Lecture("TED Talk", "What makes a good life? Lessons from the longest study on happiness", new DateTime(2024, 8, 1), new TimeSpan(10, 0, 0), address1, "Robert Waldinger", 100);
        Reception reception = new Reception("Kristin & Jonathan Mcbride", "Wedding Reception for Kristin & Jonathan Mcbride", new DateTime(2024, 8, 2), new TimeSpan(18, 0, 0), address2, "kristinMcbride@gmail.com");
        Outdoor outdoor = new Outdoor("Summer Picnic", "A fun picnic in the park", new DateTime(2024, 8, 3), new TimeSpan(12, 0, 0), address3, "Sunny High 96°F Low 90°F");

        Event[] events = { lecture, reception, outdoor };

        foreach (var eventType in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(eventType.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(eventType.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(eventType.GetShortDescription());
            Console.WriteLine();
        }
    }
}