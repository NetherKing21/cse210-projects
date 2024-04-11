using System.Dynamic;
using System.Reflection.Metadata;

public class Player : Entity
{
    //Attributes
    private List<Item> _inventory;
    private string _weapon;
    private string _armorSlot;

    //Constructor
    public Player() : base()
    {
        _imName = "Nonspecific Player";
        _inventory = new List<Item>();
        _weapon = "Fists"; // Default weapon
        // _imSpeedStat = 100; //Make the player fast!!!!
        _imActions = new List<Action> {new WeaponlessAttack(), new UseItem()};
        _imGold = 30;
    }

    //Methods
    public int GetLevel()
    {
        return _imLevel;
    }

    public List<Item> Inventory
    {
        get { return _inventory; }
    }

    public string Weapon
    {
        get { return _weapon; }
        set { _weapon = value; }
    }

    public void ArmorUp(MediumArmor armor)
    {
        _armorSlot = armor.ImGetName();
        _imArmorStat = armor.ImGetArmorValue();
    }

    public void AddToInventory(Item item)
    {
        _inventory.Add(item);
    }

    public void RemoveFromInventory(int itemIndex)
    {
        _inventory.RemoveAt(itemIndex);
    }

    public void ImUseGold(int goldUsed)
    {
        _imGold = _imGold - goldUsed;
    }

    public List<Item> ImGetInventory()
    {
        return _inventory;
    }

    // Additional methods can be added here
    public override void bmTakeAction(Entity entity, List<Player> imParty, List<Entity> entities)
    {
        // Display players actions
        Out.bmDisplayActions(_imActions);
        // Get users input
        int ui = In.bmGetUserInput(_imActions.Count()) - 1;
        //Set user
        _imActions[ui].SetUser(entity, imParty);
        // Set target
        _imActions[ui].SetTarget(entities, imParty);
        // Call that action effect
        _imActions[ui].Effect();
    }
}
