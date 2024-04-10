public class Aayush : Entity
{
    // Class Constructors
    public Aayush() : base()
    { 
        _imName = "Aayush";
        _imLevel = 1;
        _imHealth = 20;
        _imStrengthStat = 5;
        _imSpeedStat = 2;
        _imArmorStat = 5;
        _imGold = 30;
        // _imActions = new List<Action> { new BigAttack() }; 
    }

    // Class Methods
    public override void _ImLevelUp()
    {
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
        Console.WriteLine("Aayush takes action.");
    }
}
