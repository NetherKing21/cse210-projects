public abstract class Action
{
    // Attributes
    protected string _actionName;
    protected string _description;
    protected Entity _user;
    protected Player _player;
    protected List<Entity> _target;

    // Methods
    public abstract void Effect();

    public void SetUser(Entity user, List<Player> imParty)
    {
        _user = user;
        _player = imParty[0];
    }

    public abstract void SetTarget(List<Entity> entities, List<Player> imParty);

    public string GetName()
    {
        return _actionName;
    }
}