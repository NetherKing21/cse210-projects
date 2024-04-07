public class Beast : Entity
{
    // Class States

    // Class Constructors
    Beast() : base()
    {
        _imName = "Doggo";
        _imLevel = 1;
        _imHealth = 5;
        _imStrengthStat = 4;
        _imSpeedStat = 4;
        _imArmorStat = 4;
        _imGold = 7;

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
            _imArmorStat = 5;
            _imGold = 10;

        } else if (_imLevel == 2) {
            _imName = "Doggo Person";
            _imLevel = 3;
            _imHealth = 25;
            _imStrengthStat = 30;
            _imSpeedStat = 20;
            _imArmorStat = 5;
            _imGold = 20;

        }
    }

// edited by ak
public override void bmTakeAction()
{
    // Implement the logic for the Beast's action here
    Console.WriteLine("The Beast takes action.");
}


}