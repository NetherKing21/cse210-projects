public class WritingAssignment : Assignment
{
    private string _title;

    //Constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string returnValue = $"{_title} by {GetStudentName()}";
        return returnValue;
    }

}