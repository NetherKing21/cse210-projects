public class Player : Entity
{
    private List<string> _inventory;
    private string _weapon;

    public Player() : base()
    {
        _inventory = new List<string>();
        _weapon = "Fists"; // Default weapon
    }

    public List<string> Inventory
    {
        get { return _inventory; }
    }

    public string Weapon
    {
        get { return _weapon; }
        set { _weapon = value; }
    }

    public void AddToInventory(string item)
    {
        _inventory.Add(item);
    }

    public void RemoveFromInventory(string item)
    {
        _inventory.Remove(item);
    }

    // Additional methods can be added here
    public override void bmTakeAction()
    {
        // Display players actions

        // Get users input

        // Call that action effect
    }
}
