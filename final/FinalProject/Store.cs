public class Store : Event 
{
    // Class States
    private static List<Player> _imParty;
    private static Player _imShopper;
    private static List<Item> _imItemsForSale;

    // Class Constructors
    public Store() : base("Store")
    {
        // _imItemsForSale.Add(new HealthPotion());
        //_imItemsForSale.Add(new SturdySword());
        //_imItemsForSale.Add(new MediumArmor());
    }

    // Class Methods
    public void ImRun()
    {
        // Sets initial shopper
        ImGetShopper();

        // Runs shop menu
        int userChoice = -1;

        while (userChoice != 3)
        {
            // Prints Shop menu
            Console.WriteLine($"You have {_imShopper.GetGold} Gold");
            Console.WriteLine("1. Buy items");
            Console.WriteLine("2. Change shopper");
            Console.WriteLine("3. Leave shop");
            Console.Write("What would you like to do?");
            userChoice = Console.Read();

            // Decides what to do
            if (userChoice == 1)
            {
                ImShopItems();
            } else if (userChoice == 2)
            {
                ImGetShopper();
            } else if (userChoice == 3 )
            {
                // Pass
            } else 
            {
                Console.WriteLine("Error: Enter a number 1-3.");
            }
        }
    } 
    // Get Shopper
    public void ImGetShopper()
    {
        foreach(Player player in _imParty)
        {
            Console.WriteLine($"{_imParty.IndexOf(player) + 1}. {player.GetName()}");
        }

        Console.Write("Who is shopping");
        int shopperIndex = Console.Read() - 1;
        _imShopper = _imParty.ElementAt(shopperIndex);
    }
    // List items
    public void ImShopItems()
    {
        foreach(Item item in _imItemsForSale)
        {
            Console.WriteLine($"{_imItemsForSale.IndexOf(item) + 1}. {item.ImGetName()}");
        }

        Console.Write("What would you like to buy");
        int itemIndex = Console.Read() - 1;
        ImBuyItem(itemIndex);
    }

    // Buy an item
    public void ImBuyItem(int itemIndex)
    {
        if (_imShopper.GetGold() >= _imItemsForSale.ElementAt(itemIndex).ImGetCost())
        {
            _imShopper.AddToInventory(_imItemsForSale.ElementAt(itemIndex));
        } else 
        {
            Console.WriteLine("Insufficient Gold");
        }
    }
}