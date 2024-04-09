public abstract class Item 
{
    // Class States
    protected string _imItemName;
    protected int _imCost;

    // Class Constructor
    public Item () {}

    // Class Methods
    public string ImGetName()
    {
        return _imItemName;
    }
    public int ImGetCost()
    {
        return _imCost;
    }
    public abstract void ImBuyItem ();
    public abstract void ImUseItem();
}