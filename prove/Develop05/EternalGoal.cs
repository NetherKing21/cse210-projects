public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    // Methods
    public override string bmToCSV()
    {
        string returnValue = $"EternalGoal:{_name},{_description},{_points}";
        return returnValue;
    }
    public override string bmToString()
    {
        string mark = "[ ]";
        if (bmIsCompleted())
        {
            mark = "[X]";
        }
        string returnValue = $"{mark} {_name} ({_description})";
        return returnValue;
    }
    public override bool bmIsCompleted()
    {
        bool returnValue = false;
        return returnValue;
    }
    public override int bmCalPoints()
    {
        int returnValue = _points;
        return returnValue;
    }
}
