public class Undead : Entity
{
    // Class Statesybtg

    // Class Constructors
    public Undead(int level) : base()
    {
        _imName = "Undead";
        _imLevel = level;
        _imHealth = 10 * _imLevel;
        _imStrengthStat = 2 * _imLevel;
        _imSpeedStat = 2 * _imLevel;
        _imArmorStat = 2 * _imLevel;
        _imGold = 5  * _imLevel;

    }

    // Class Methods

}