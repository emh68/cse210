using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private int _pointsToNextLevel;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _pointsToNextLevel = 500;
    }

    public void IncreaseScore(int points)
    {
        _score += points;
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        while (_score >= _pointsToNextLevel)
        {
            _score -= _pointsToNextLevel;
            _level++;
            _pointsToNextLevel = (int)(_pointsToNextLevel * 2);
            Console.WriteLine($"Congratulations! You reached level {_level}!");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Current Level: {_level}");
        Console.WriteLine($"Points to next level: {_pointsToNextLevel - _score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetName());
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

    public void SaveGoals(string filename)
    {
        using (StreamWriter save = new StreamWriter(filename))
        {
            save.WriteLine($"{_score}|{_level}|{_pointsToNextLevel}");
            foreach (var goal in _goals)
            {
                string savedString = goal.GetSavedString();
                save.WriteLine(savedString);
            }
        }
        Console.WriteLine($"Goals saved as {filename}");
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string[] playerInfo = reader.ReadLine().Split('|');
            _score = int.Parse(playerInfo[0]);
            _level = int.Parse(playerInfo[1]);
            _pointsToNextLevel = int.Parse(playerInfo[2]);

            string goalData;
            while ((goalData = reader.ReadLine()) != null)
            {
                Goal goal = ParseGoalData(goalData);
                _goals.Add(goal);
            }
        }
        Console.WriteLine($"Goals loaded from {filename}");
    }

    private Goal ParseGoalData(string data)
    {
        string[] parts = data.Split('|');

        if (parts.Length < 4)
        {
            return null;
        }

        string type = parts[0].Trim();
        string name = parts[1].Trim();
        string description = parts[2].Trim();
        int points = int.Parse(parts[3].Trim());

        if (type == "SimpleGoal" && parts.Length == 5)
        {
            bool isComplete = bool.Parse(parts[4].Trim());
            return new SimpleGoal(name, description, points, isComplete, this);
        }
        else if (type == "EternalGoal" && parts.Length == 4)
        {
            return new EternalGoal(name, description, points, this);
        }
        else if (type == "ChecklistGoal" && parts.Length == 7)
        {
            int amountCompleted = int.Parse(parts[4].Trim());
            int target = int.Parse(parts[5].Trim());
            int bonus = int.Parse(parts[6].Trim());
            return new ChecklistGoal(name, description, points, amountCompleted, target, bonus, this);
        }
        return null;
    }
}
