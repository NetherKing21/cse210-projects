
public class Undead : Entity
{
    // Class State

    // Class Constructors
    public Undead() : base()
    {
        _imName = "Ghost";
        _imLevel = 1;
        _imHealth = 2;
        _imStrengthStat = 1;
        _imSpeedStat = 5;
        _imArmorStat = 2;
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
            _imStrengthStat = 2;
            _imSpeedStat = 2;
            _imArmorStat = 2;
            _imGold = 1;

        } else if (_imLevel == 2) {
            _imName = "Spooky Octapus";
            _imLevel = 3;
            _imHealth = 100;
            _imStrengthStat = 5;
            _imSpeedStat = 1;
            _imArmorStat = 20;
            _imGold = 10;

        }
    }

    public override void bmTakeAction(Entity user, List<Player> imParty, List<Entity> targets)
    {
        Console.WriteLine("Boo! (Ineffective)");
        Thread.Sleep(3000);
        //Chose a random number with the max number being the length of _imActions

        //Set random target from entities (should be the party list in Combat !!Combat need to be updated to change which list in given based on which entity is taking its action)

        //Call action.effect
    }

}