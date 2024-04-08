public abstract class Item 
{
    // Class States
    protected string _imItemName;
    protected int _imCost;

    // Class Constructor
    public Item () {}

    // Class Methods
    public abstract void ImBuyItem ();
    public abstract void ImUseItem();
}