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
            _imStrengthStat = 2;
            _imSpeedStat = 2;
            _imArmorStat = 2;
            _imGold = 50;

        } else if (_imLevel == 2) {
            _imName = "IRS";
            _imLevel = 3;
            _imHealth = 50;
            _imStrengthStat = 5;
            _imSpeedStat = 10;
            _imArmorStat = 10;
            _imGold = 500;
        }
    }

    public override void bmTakeAction(Entity user, List<Player> imParty, List<Entity> targets)
    {
        Console.WriteLine("this dude did nothing");
        Thread.Sleep(3000);
        //Chose a random number with the max number being the length of _imActions

        //Set random target from entities (should be the party list in Combat !!Combat need to be updated to change which list in given based on which entity is taking its action)

        //Call action.effect
    }
}