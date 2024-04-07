public class Bandito : Entity
{
    // Class States

    // Class Constructors
    Bandito() : base()
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

    //edited by ak
    public override void bmTakeAction()
    {
        // Implement the logic for the Beast's action here
        Console.WriteLine("The Beast takes action.");
    }


}