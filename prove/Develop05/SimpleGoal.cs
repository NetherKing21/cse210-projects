public class SimpleGoal : Goal
{
    // Attributes
    private bool _completed;

    // Constructor
    public SimpleGoal(string name, string description, int points, bool completed = false) : base(name, description, points)
    {
        _completed = completed;
    }

    // Methods
    public override string bmToCSV()
    {
        string returnValue = $"SimpleGoal:{_name},{_description},{_points},{_completed}";
        return returnValue;
    }
    public override string bmToString()
    {
        string mark = "[ ]";
        if (_completed)
        {
            mark = "[X]";
        }
        string returnValue = $"{mark} {_name} ({_description})";
        return returnValue;
    }
    public override bool bmIsCompleted()
    {
        bool returnValue = _completed;
        return returnValue;
    }
    public override int bmCalPoints()
    {
        _completed = true;
        int returnValue = _points;
        return returnValue;
    }
}