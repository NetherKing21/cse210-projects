public class Ranger : Entity
{
    // Class Constructors
    public Ranger() : base()
    { 
        _imName = "Ranger";
        _imLevel = 1;
        _imHealth = 15;
        _imStrengthStat = 3;
        _imSpeedStat = 3;
        _imArmorStat = 2;
        _imGold = 20;
        // _imActions = new List<Action> { new RangedAttack() }; 
    }

    // Class Methods
    public override void _ImLevelUp()
    {
        if (_imLevel == 1)
        {
            _imName = "Archer";
            _imLevel = 2;
            _imHealth = 30;
            _imStrengthStat = 4;
            _imSpeedStat = 4;
            _imArmorStat = 3;
            _imGold = 50;
        }
        else if (_imLevel == 2)
        {
            _imName = "Sniper";
            _imLevel = 3;
            _imHealth = 45;
            _imStrengthStat = 6;
            _imSpeedStat = 6;
            _imArmorStat = 4;
            _imGold = 100;
        }
    }

    public override void bmTakeAction(Entity user, List<Player> imParty, List<Entity> targets)
    {
        Console.WriteLine("The ranger takes action.");
    }
}
