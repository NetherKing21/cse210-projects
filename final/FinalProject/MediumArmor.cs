public class MediumArmor : Item
{
    // Class States
    private int _imArmorValue;

    // Class Constructor
    public MediumArmor()
    {
        _imItemName = "Medium Armor";
        _imCost = 25;
        _imArmorValue = 10;
    }

    // Class Methods
    public int ImGetArmorValue()
    {
        return _imArmorValue;
    }

}