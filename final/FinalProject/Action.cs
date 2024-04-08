public abstract class Action
{
    // Attributes
    protected string _actionName;
    protected string _description;
    protected Entity _user;
    protected List<Entity> _target;

    // Methods
    public abstract void Effect();

    public void SetUser(Entity user)
    {
        _user = user;
    }

    public abstract void SetTarget(List<Entity> entities);

    public string GetName()
    {
        return _actionName;
    }
}