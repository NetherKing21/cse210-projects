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

      // Class Methods
    public override void ImBuyItem()
    {
        // Implement logic for buying the health potion
        Console.WriteLine($"Bought {_imItemName} for {_imCost} gold.");
    }

    public override void ImUseItem()
    {
        // Implement logic for using the health potion
        Console.WriteLine($"Used {_imItemName}. Restored {_imHealAmount} health.");
    }
}