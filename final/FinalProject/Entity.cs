public abstract class Entity
{
    // Class States
    protected string _imName;
    protected int _imLevel;
    protected int _imHealth;
    protected int _imStrengthStat;
    protected int _imSpeedStat;
    protected int _imArmorStat;
    protected int _imGold;
    protected List<Action> _imActions = new List<Action>();

    // Class Constructors
    public Entity()
    {
        // Trying to decide if I set it to all Nulls or if I do this.
        _imName = "EmptyEntity";
        _imLevel = 1;
        _imHealth = 1;
        _imStrengthStat = 1;
        _imSpeedStat = 1;
        _imArmorStat = 1;
    }

    // Class Methods
    /*Depending on how the combat works I'll either make 
    Get___ for individual parts or send an entire string 
    In example:*/
    
    public string GetName()
    {
        return _imName;
    }

    public int GetHealth()
    {
        return _imHealth; 
    }

    public int GetStrength()
    {
        return _imStrengthStat; 
    }
    public int GetSpeed()
    {
        return _imSpeedStat; 
    }
    public int GetGold()
    {
        return _imGold;
    }
    public List<Action> GetActionList()
    {
        return _imActions; 
    }

    public void _ImTakeDamage(int damage)
    {
        damage = damage - _imArmorStat;
        if(damage < 1)
        {
            damage = 1;
        }
        _imHealth = _imHealth - damage;
    }

    public virtual void _ImLevelUp()
    {
        _imLevel = _imLevel + 1;
    }

    public abstract void bmTakeAction(Entity user, List<Player> imParty, List<Entity> targets);
}

