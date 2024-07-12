using System;

public class NegativeGoal : Goal
{
    private int _penality;
    private bool _isCommited;
    private int _count;

    public NegativeGoal(string name, string description, int points, int penality) : base(name, description, points)
    {

        _penality = penality;
        _isCommited = false;
        _count = 0;

    }

    public override void RecordEvent()
    {
        _count += 1;
        int deduction = GetPoints();
        if (deduction < 0)
        {
            SetPoints(deduction);
        }
        else
        {
            SetPoints(-deduction);
        }
        Console.WriteLine($"Sorry! You have lost {GetPoints()}!");
        _isCommited = true;
        GetStringRepresentation();
        if (_count >= 3)
        {
            int penalityDeduction = GetPoints() - _penality;
            SetPoints(penalityDeduction);
            Console.WriteLine($"Sorry! You have commited this Negative Goal {_count} or more times so you lost {GetPoints()}!");
        }

    }

    public override bool IsComplete()
    {
        return _isCommited;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{GetName()},{GetDescription()},{GetPoints()},{_penality},{_isCommited}";
    }
}