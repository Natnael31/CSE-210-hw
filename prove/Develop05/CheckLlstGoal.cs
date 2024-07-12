using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            int total = GetPoints();
            total += _bonus;
            SetPoints(total);
            Console.WriteLine($"Congratulations! You have earned {GetPoints()}!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()}!");
        }

        GetStringRepresentation();

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailString()
    {
        string result;
        if (_amountCompleted == _target)
        {
            result = $"[X] {GetName()} ({GetDescription()}) --- Currently completed:{_amountCompleted}/{_target}";
        }
        else
        {
            result = $"[ ] {GetName()} ({GetDescription()}) --- Currently completed:{_amountCompleted}/{_target}";
        }
        return result;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted} ";
    }
}