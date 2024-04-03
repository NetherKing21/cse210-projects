public class Warrior : Player
{
    private int _akStrengthStat;
    private string _startingWeapon;
    private List<string> _startingGear;

    public Warrior() : base()
    {
        _akStrengthStat = 10; // Default 
        _startingWeapon = "Sword"; // Default 
        _startingGear = new List<string> { "Armor", "Health Potion", "Mana Potion" }; // Default starting gear
    }

    public int StrengthStat
    {
        get { return _akStrengthStat; }
        set { _akStrengthStat = value; }
    }

    public string StartingWeapon
    {
        get { return _startingWeapon; }
        set { _startingWeapon = value; }
    }

    public List<string> StartingGear
    {
        get { return _startingGear; }
    }

    // public void Attack(Entity target)
    // {
    //     // Placeholder logic for attacking
    //     int damage = _akStrengthStat; // For simplicity, assume strength stat is directly added as damage
    //     target.TakeDamage(damage);
    // }

}