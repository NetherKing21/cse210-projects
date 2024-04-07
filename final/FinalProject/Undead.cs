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

    // edited by ak
    public override void bmTakeAction()
    {
        // Implement the logic for the Beast's action here
        Console.WriteLine("The Beast takes action.");
    }

}