public class Item
{
    // Attributes
    private string _name;
    private string _description;

    // Constructors
    public Item(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    // Methods 
    public virtual void UseItem(Entity target)
    {
        // Placeholder 
        Console.WriteLine($"Using {_name} on {target.GetName()}."); // Example
    }
}