public class Ranger : Player
{
    private int _akStat;
    private string _startingWeapon;
    private List<string> _startingGear;

    public Ranger() : base()
    {
        _akStat = 10; // Default d
        _startingWeapon = "Bow and Arrows"; // Default 
        _startingGear = new List<string> { "Leather Armor", "Health Potion", "Stamina Potion" }; // Default 
    }

    public int Stat
    {
        get { return _akStat; }
        set { _akStat = value; }
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

    // public void ShootArrow(Entity target)
    // {
    //     // Placeholder logic for shooting an arrow
    //     int damage = _akStat; // For simplicity, assume dexterity stat is directly added as damage
    //     target.InTakeDamage(damage);
    // }

}
