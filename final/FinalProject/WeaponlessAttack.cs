using System.Reflection.Metadata;

public class WeaponlessAttack : Action
{
    // Method
    public WeaponlessAttack(Entity user, Entity target) : base(user, target)
    {

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
}