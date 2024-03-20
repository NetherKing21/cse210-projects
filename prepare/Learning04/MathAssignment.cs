using System.Reflection.Metadata.Ecma335;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //Constructor
    public MathAssignment(string name, string section, string problems, string topic = "Math") : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    } 

    public string GetHomeworkList()
    {
        string returnValue = $"{_textbookSection} {_problems}";
        return returnValue;
    }
}