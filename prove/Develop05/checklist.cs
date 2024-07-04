public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus, GoalManager goalManager) : base(name, description, points, goalManager)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        _goalManager.IncreaseScore(GetPoints());
        if (_amountCompleted >= _target)
        {
            _goalManager.IncreaseScore(_bonus);
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetSavedString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} - {GetDescription()} - {GetPoints()} points, Completed {_amountCompleted}/{_target} times, Bonus: {_bonus} points";
    }
}