using System;
using System.Collections;
using System.Net;

class Combat
{
    // Attributes
    private static List<Entity> _bmEnemies;
    private static List<Entity> _bmParty;
    private static List<Entity> _bmAllEntities;
    // private static IEnumerable<Entity> _bmActionOrder;


    // Constructor
    public Combat(List<Entity> party, List<Entity> enemies)
    {
        _bmParty = party;
        _bmEnemies = enemies;
        _bmAllEntities = party;
        foreach(Entity entity in _bmEnemies)
        {
            _bmAllEntities.Add(entity);
        }
    }

    // Methods
    public static bool Fight()
    {
        bool end = false;
        bool victory = false;
        while(!end)
        {
            // Make Action Order
            IEnumerable<Entity> _bmActionOrder = _bmAllEntities.OrderBy<Entity, TKey>(Entity => Entity.GetSpeed);

            // Check if Party is dead //Will have to change this to check for just the player if we add allies, otherwise it will work fine
            if(!bmIsAlive(_bmParty))
            {
                victory = false;
                end = true;
            } // Check if enemy team is dead
            else if(!bmIsAlive(_bmEnemies))
            {
                victory = true;
                end = true;
            }
        }
        return victory;
    }

    private static bool bmIsAlive(List<Entity> team)
    {
        bool returnValue = false;
        List<bool> isAliveList = new List<bool>();
        foreach (Entity entity in team)
        {
            if(entity.GetHealth() > 0)
            {
                isAliveList.Add(true);
            }
            else
            {
                isAliveList.Add(false);
            }
        }
        foreach(Boolean x in isAliveList)
        {
            if(x)
            {
                returnValue = true;
            }
        }
        return returnValue;
    }

    private static List<Entity> bmMakeActionOrderList()
    {
        List<Entity> listCopy = _bmAllEntities;
        List<Entity> ActionOrderList = new List<Entity>();
        while(ActionOrderList.Count < _bmAllEntities.Count)
        {
            int maxSpeed = -1;
            foreach(Entity entity in listCopy)
            {
                if(entity.GetSpeed() > maxSpeed)
                {
                    maxSpeed = entity.GetSpeed();
                    Entity maxEntity = entity;
                }
            }
            ActionOrderList.Add(maxEntity);
            listCopy.Remove(maxEntity);
        }
    }
}