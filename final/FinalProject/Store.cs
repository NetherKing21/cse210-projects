public class Store : Event 
{
    // Class States
    private static List<Player> _imParty = new List<Player>();
    private static Player _imShopper;
    private static List<Item> _imItemsForSale = new List<Item>();

    // Class Constructors
    public Store(List<Player> party) : base("Store")
    {
        // Copies party list to the store
        foreach (Player player in party)
        {
            _imParty.Add(player); 
        }

        // Items in the store
        _imItemsForSale.Add(new HealthPotion());
        //_imItemsForSale.Add(new SturdySword());
        _imItemsForSale.Add(new MediumArmor());
    }

    // Class Methods
    public void ImRun()
    {
        // Sets initial shopper
        ImGetShopper();
        Console.WriteLine();

        // Runs shop menu
        string userChoice = "";

        while (userChoice != "3")
        {
            // Prints Shop menu
            Console.WriteLine($"You have {_imShopper.GetGold()} Gold");
            Console.WriteLine("1. Buy items");
            Console.WriteLine("2. Change shopper");
            Console.WriteLine("3. Leave shop");
            Console.WriteLine("What would you like to do?");
            Console.Write("> ");
            userChoice = Console.ReadLine();

            // Decides what to do
            if (userChoice == "1")
            {
                ImShopItems();
            } else if (userChoice == "2")
            {
                ImGetShopper();
            } else if (userChoice == "3")
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

        Console.WriteLine("Who is shopping: ");
        Console.Write("> ");
        int shopperIndex = int.Parse(Console.ReadLine()) - 1;
        _imShopper = _imParty.ElementAt(shopperIndex);
    }
    // List items
    public void ImShopItems()
    {
        foreach(Item item in _imItemsForSale)
        {
            Console.WriteLine($"{_imItemsForSale.IndexOf(item) + 1}. {item.ImGetName()}");
        }

        Console.WriteLine("What would you like to buy?");
        Console.Write("> ");
        int itemIndex = int.Parse(Console.ReadLine()) - 1;
        ImBuyItem(itemIndex);
    }

    // Buy an item
    public void ImBuyItem(int itemIndex)
    {
        int cost = _imItemsForSale.ElementAt(itemIndex).ImGetCost();
        if (_imShopper.GetGold() >= cost)
        {
            if(itemIndex == 0)
            {
                _imShopper.ImUseGold(cost);
                _imShopper.AddToInventory(new HealthPotion());
            } 
            else if (itemIndex == 1)
            {
                _imShopper.ImUseGold(cost);
                _imShopper.ArmorUp(new MediumArmor());
            }
        } else 
        {
            Console.WriteLine("Insufficient Gold");
        }
    }
}