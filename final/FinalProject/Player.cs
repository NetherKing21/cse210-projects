using System.Reflection.Metadata;

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
    public override void bmTakeAction(List<Entity> entities)
    {
        // Display players actions
        Out.bmDisplayActions(_imActions);
        // Get users input
        int ui = In.bmGetUserInput(_imActions.Count()) - 1;
        // Set target
        _imActions[ui].SetTarget(entities);
        // Call that action effect
        _imActions[ui].Effect();
    }
}
