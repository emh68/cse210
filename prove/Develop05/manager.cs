using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void IncreaseScore(int points)
    {
        _score += points;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalInfo()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        bool goalFound = false;

        foreach (var goal in _goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                Console.WriteLine($"Event recorded for {goalName}. Current score: {_score}");
                goalFound = true;
                break;
            }
        }

        if (!goalFound)
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            _score = int.Parse(reader.ReadLine());

            string goalData;
            while ((goalData = reader.ReadLine()) != null)
            {
                Goal goal = ParseGoalFromData(goalData);
                _goals.Add(goal);
            }
        }
    }

    //I need to add the logic here currently null
    private Goal ParseGoalFromData(string data)
    {
        return null;
    }

}