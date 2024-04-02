public class Bandito : Entity
{
    // Class States

    // Class Constructors
    Bandito(int level) : base()
    {
        if (level == 3) {
            _imName = "Mob Boss";
            _imLevel = level;
            _imHealth = 50;
            _imStrengthStat = 5;
            _imSpeedStat = 2;
            _imArmorStat = 2;
            _imGold = 5;

        } else if(level == 2){
            _imName = "Bandito";
            _imLevel = level;
            _imHealth = 10;
            _imStrengthStat = 2;
            _imSpeedStat = 2;
            _imArmorStat = 2;
            _imGold = 5;

        } else /*level 1*/{
            _imName = "Bandito";
            _imLevel = level;
            _imHealth = 10;
            _imStrengthStat = 2;
            _imSpeedStat = 2;
            _imArmorStat = 2;
            _imGold = 5;

        }

    }

    // Class Methods
    
}