public class UseItem : Action
{
    // Class States
    private List<Player> _imParty = new List<Player>();
    private Player _imAffectedPlayer;
    private List<Item> _imItems = new List<Item>();
    private Item _imItemUsed;




    // Class Constructor
    public UseItem() 
    {
        _actionName = "Use Item";
    }

    // Class Methods

    public override void Effect()
    {
        // Selects an item to use
        _imItems = _imParty[0].ImGetInventory();
        
        int i = 1;
        foreach (Item item in _imItems)
        {
            Console.WriteLine($"{i}.{item.ImGetName()}");
            i ++;
        }
        Console.WriteLine("What item would you like to use?");
        Console.Write("> ");
        int userChoice = int.Parse(Console.ReadLine()) - 1;
        _imItemUsed = _imItems[userChoice];            
        
        // Uses the chosen item 
        _imAffectedPlayer._ImTakeDamage(_imItemUsed.ImDamageAmount());
        _imParty[0].RemoveFromInventory(userChoice);
        _description = $"{_user.GetName()} healed {_imAffectedPlayer.GetName()}\n{_imAffectedPlayer} is now at {_imAffectedPlayer.GetHealth()} health.";
        Out.bmActionMessage(_description);
    }

    public override void SetTarget(List<Entity> entities , List<Player> imParty)
    {
        _imParty = imParty;

        int i = 1;
        foreach (Player player in _imParty)
        {
            Console.WriteLine($"{i}.{player.GetName()}");
            i ++;
        }
        Console.WriteLine("Who would you like to effect?");
        Console.Write("> ");
        int userChoice = int.Parse(Console.ReadLine()) - 1;
        _imAffectedPlayer = _imParty[userChoice];
    }
}
