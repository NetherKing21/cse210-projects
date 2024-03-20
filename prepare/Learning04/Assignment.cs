public class Assignment
{
    private string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        string returnValue = $"{_studentName} - {_topic}";
        return returnValue;
    } 

    public string GetStudentName()
    {
        string returnValue = _studentName;
        return returnValue;
    }
}