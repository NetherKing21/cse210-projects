public class Bandito : Entity
{
    // Class States

    // Class Constructors
    public Bandito() : base()
    { 
            _imName = "Bandito";
            _imLevel = 1;
            _imHealth = 10;
            _imStrengthStat = 2;
            _imSpeedStat = 2;
            _imArmorStat = 2;
            _imGold = 10;
            _imActions = new List<Action> {new WeaponlessAttack()};
    }

    // Class Methods
    public override void _ImLevelUp()
    {
        // Finds the current level and raises it.
        
        // This could be changed from preset values to math later.
        if (_imLevel == 1) {
            _imName = "Mob Boss";
            _imLevel = 2;
            _imHealth = 25;
            _imStrengthStat = 7;
            _imSpeedStat = 2;
            _imArmorStat = 3;
            _imGold = 50;

        } else if (_imLevel == 2) {
            _imName = "IRS";
            _imLevel = 3;
            _imHealth = 50;
            _imStrengthStat = 10;
            _imSpeedStat = 10;
            _imArmorStat = 5;
            _imGold = 500;
        }
    }

    public override void bmTakeAction(Entity user, List<Player> imParty, List<Entity> targets)
    {
        Console.WriteLine("this dude did nothing");
        Console.WriteLine($"The {_imName} takes action.");
        //Chose a random number with the max number being the length of _imActions
        Random random = new Random();
        int randomInt = random.Next(_imActions.Count());

        //Set user
        _imActions[randomInt].SetUser(user, imParty);
        // Set target
        _imActions[randomInt].SetTarget(targets, imParty);
        // Call that action effect
        _imActions[randomInt].Effect();
        Thread.Sleep(2000);
    }
}