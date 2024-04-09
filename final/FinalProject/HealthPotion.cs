public class HealthPotion : Item
{
    // Class States
    private int _imHealAmount;

    // Class Constructor
    public HealthPotion() : base () 
    {
        _imItemName = "Health Potion";
        _imCost = 2;
        _imHealAmount = 10;
    }
}