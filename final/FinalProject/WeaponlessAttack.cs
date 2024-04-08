using System.Reflection.Metadata;

public class WeaponlessAttack : Action
{
    //Attributes

    // Method
    public WeaponlessAttack() 
    {
        _actionName = "Punch";
        _description = "You punch someone";
    }

    //Methods
    public override void Effect()
    {
        int damage = _user.GetStrength();
        foreach(Entity target in _target)
        {
            target._ImTakeDamage(damage);
        }
    }

    public override void SetTarget(List<Entity> entities)
    {
        Out.bmDisplayTargets(entities);
        int ui = In.bmGetUserInput(entities.Count()) - 1;
        _target = new List<Entity> {entities[ui]};
    }
}