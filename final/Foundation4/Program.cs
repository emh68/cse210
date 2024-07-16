using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2024, 7, 15), 180, 20);
        Bike bike = new Bike(new DateTime(2024, 7, 15), 120, 10);
        Swimming swimming = new Swimming(new DateTime(2024, 7, 15), 60, 32);

        Activity[] activities = { running, bike, swimming };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}