public class CheckListGoal : Goal
{
    // Attributes
    private int _bonus;
    private int _total;
    private int _current;

    // Constructor
    public CheckListGoal(string name, string description, int points, int bonus, int total, int current = 0) : base(name, description, points)
    {
        _bonus = bonus;
        _total = total;
        _current = current;
    }

    // Methods
    public override string bmToCSV()
    {
        string returnValue = $"CheckListGoal:{_name},{_description},{_points},{_bonus},{_total},{_current}";
        return returnValue;
    }
    public override string bmToString()
    {
        string mark = "[ ]";
        if (bmIsCompleted())
        {
            mark = "[X]";
        }
        string returnValue = $"{mark} {_name} ({_description} {_current}/{_total})";
        return returnValue;
    }
    public override bool bmIsCompleted()
    {
        if(_total == _current)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override int bmCalPoints()
    {
        _current++;
        int returnValue = _points;
        if (bmIsCompleted())
        {
            returnValue += _bonus;
        }
        return returnValue;
    }
}