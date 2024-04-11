
public class Undead : Entity
{
    // Class State

    // Class Constructors
    public Undead() : base()
    {
        _imName = "Ghost";
        _imLevel = 1;
        _imHealth = 2;
        _imStrengthStat = 4;
        _imSpeedStat = 5;
        _imArmorStat = 1;
        _imGold = 0;
        _imActions = new List<Action> {new WeaponlessAttack()};

    }

    // Class Methods
    public override void _ImLevelUp()
    {
        // Finds the current level and raises it.
        
        // This could be changed from preset values to math later.
        if (_imLevel == 1) {
            _imName = "Zambie";
            _imLevel = 2;
            _imHealth = 10;
            _imStrengthStat = 10;
            _imSpeedStat = 2;
            _imArmorStat = 2;
            _imGold = 1;

        } else if (_imLevel == 2) {
            _imName = "Spooky Octapus";
            _imLevel = 3;
            _imHealth = 70;
            _imStrengthStat = 15;
            _imSpeedStat = 1;
            _imArmorStat = 5;
            _imGold = 10;

        }
    }

    public override void bmTakeAction(Entity user, List<Player> imParty, List<Entity> targets)
    {
        Console.WriteLine("Boo! (Ineffective)");
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