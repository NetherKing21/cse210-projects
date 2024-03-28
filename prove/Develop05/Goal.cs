public abstract class Goal
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    //Methods (Most are going to be abstract)
    public abstract string bmToCSV();
    public abstract string bmToString();
    public abstract bool bmIsCompleted();
    public abstract int bmCalPoints();
}