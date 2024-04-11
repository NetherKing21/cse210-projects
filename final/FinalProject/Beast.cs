public class Beast : Entity
{
    // Class States

    // Class Constructors
    public Beast() : base()
    {
        _imName = "Doggo";
        _imLevel = 1;
        _imHealth = 5;
        _imStrengthStat = 4;
        _imSpeedStat = 4;
        _imArmorStat = 1;
        _imGold = 7;
        _imActions = new List<Action> {new WeaponlessAttack()};
    }

    // Class Methods
    public override void _ImLevelUp()
    {
        // Finds the current level and raises it.
        
        // This could be changed from preset values to math later.
        if (_imLevel == 1) {
            _imName = "Scary Doggo";
            _imLevel = 2;
            _imHealth = 10;
            _imStrengthStat = 10;
            _imSpeedStat = 2;
            _imArmorStat = 2;
            _imGold = 10;

        } else if (_imLevel == 2) {
            _imName = "Doggo Person";
            _imLevel = 3;
            _imHealth = 25;
            _imStrengthStat = 30;
            _imSpeedStat = 20;
            _imArmorStat = 3;
            _imGold = 20;

        }
    }

    public override void bmTakeAction(Entity user, List<Player> imParty, List<Entity> targets)
    {
        Console.WriteLine("there's just a good boy");
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