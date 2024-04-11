using System.Reflection.Metadata;

public class WeaponlessAttack : Action
{
    //Attributes

    // Method
    public WeaponlessAttack() 
    {
        _actionName = "Punch";
    }

    //Methods
    public override void Effect()
    {
        int damage = _user.GetStrength();
        foreach(Entity target in _target)
        {
            target._ImTakeDamage(damage);
        }
        _description = $"{_user.GetName()} punched {_target[0].GetName()}";
        Out.bmActionMessage(_description);
        Thread.Sleep(2000);
    }

    public override void SetTarget(List<Entity> entities , List<Player> imParty)
    {
        if(_user.GetType() == typeof(Aayush) || _user.GetType() == typeof(Warrior) || _user.GetType() == typeof(Ranger))
        {
            Out.bmDisplayTargets(entities);
            int ui = In.bmGetUserInput(entities.Count()) - 1;
            _target = new List<Entity> {entities[ui]};
        }
        else
        {
            Random random = new Random();
            int randomInt = random.Next(entities.Count());
            _target = new List<Entity> {entities[randomInt]};
        }
    }
}