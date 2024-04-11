public class Warrior : Player
{
    // Class Constructors
    public Warrior() : base()
    { 
        _imName = "Warrior";
        _imLevel = 1;
        _imHealth = 20;
        _imStrengthStat = 5;
        _imSpeedStat = 2;
        _imArmorStat = 5;
        _imGold = 30;
        _imActions = new List<Action> {new WeaponlessAttack(), new UseItem()};
    }

    // Class Methods
    public override void _ImLevelUp()
    {
        //Gain a level
        //Update Stats
        if (_imLevel == 1)
        {
            _imName = "Knight";
            _imLevel = 2;
            _imHealth = 40;
            _imStrengthStat = 8;
            _imSpeedStat = 3;
            _imArmorStat = 8;
            _imGold = 60;
        }
        else if (_imLevel == 2)
        {
            _imName = "Champion";
            _imLevel = 3;
            _imHealth = 60;
            _imStrengthStat = 12;
            _imSpeedStat = 4;
            _imArmorStat = 12;
            _imGold = 120;
        }
    }

    public override void bmTakeAction(Entity user, List<Player> imParty, List<Entity> targets)
    {
        Console.WriteLine($"The {_imName} takes action.");
        // Display players actions
        Out.bmDisplayActions(_imActions);
        // Get users input
        int ui = In.bmGetUserInput(_imActions.Count()) - 1;
        //Set user
        _imActions[ui].SetUser(user, imParty);
        // Set target
        _imActions[ui].SetTarget(targets, imParty);
        // Call that action effect
        _imActions[ui].Effect();
    }
}
