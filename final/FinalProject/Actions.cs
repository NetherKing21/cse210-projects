public abstract class Action
{
    // Attributes
    protected Entity _user;
    protected List<Entity> _target;

    // Constructor
    public Action(Entity user, Entity target)
    {
        _user = user;
        _target.Add(target);
    }

    public Action(Entity user, List<Entity> targets)
    {
        _user = user;
        _target = targets;
    }

    // Methods
    public abstract void Effect();
}