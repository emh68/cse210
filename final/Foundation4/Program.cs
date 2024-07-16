using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2024, 7, 15), 180, 20);
        Running running1 = new Running(new DateTime(2024, 7, 16), 45, 5);
        Running running2 = new Running(new DateTime(2024, 7, 17), 60, 8);
        Bike bike = new Bike(new DateTime(2024, 7, 15), 120, 10);
        Bike bike1 = new Bike(new DateTime(2024, 7, 16), 90, 15);
        Bike bike2 = new Bike(new DateTime(2024, 7, 17), 60, 12);
        Swimming swimming = new Swimming(new DateTime(2024, 7, 15), 60, 32);
        Swimming swimming1 = new Swimming(new DateTime(2024, 7, 16), 45, 40);
        Swimming swimming2 = new Swimming(new DateTime(2024, 7, 17), 30, 20);

        Activity[] activities = { running, running1, running2, bike, bike1, bike2, swimming, swimming1, swimming2 };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}