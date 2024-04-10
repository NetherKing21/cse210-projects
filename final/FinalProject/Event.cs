using System.Runtime;

public abstract class Event
{
    //Attributes
    protected string _eventName;

    //Constructor
    public Event(string name)
    {
        _eventName = name;
    }

    //Methods
    // public abstract void bmEnterEvent();
}