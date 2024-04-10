using System;
using System.Collections;
using System.Net;

class Combat : Event
{
    // Attributes
    private List<Entity> _bmEnemies;
    private List<Entity> _bmParty;
    private List<Entity> _bmAllEntities;
    private List<Entity> _bmActionOrder;
    private List<Player> _imParty;


    // Constructor
    public Combat(string name, List<Entity> party, List<Player> imParty, List<Entity> enemies) : base(name)
    {
        _bmParty = new List<Entity>(party);
        _imParty = new List<Player>(imParty);
        _bmEnemies = new List<Entity>(enemies);
        _bmAllEntities = new List<Entity>(party);
        foreach(Entity entity in _bmEnemies)
        {
            _bmAllEntities.Add(entity);
        }
    }

    // Methods
    public List<Entity> GetEnemies()
    {
        return _bmEnemies;
    }
    public bool Fight()
    {
        bool end = false;
        bool victory = false;
        //Display combat start message
        Out.bmStartCombatMessage();

        while(!end)
        {
            // Make Action Order
            _bmActionOrder = bmMakeActionOrderList();
            foreach(Entity entity in _bmActionOrder)
            {
                //Display Combat information
                Out.bmDisplayCombat(_bmParty, _bmEnemies);

                // Add if statement here to check that the player/someone from the party is acting
                if(_bmParty.Contains(entity))
                {
                    entity.bmTakeAction(entity, _imParty, _bmEnemies);
                    //Check to see if enemies have died
                    //if they have remove from allentities list
                }
                else
                {
                    entity.bmTakeAction(entity, _imParty, _bmParty);
                    //Check to see if player/allies have died
                    //if they have remove from allentities list
                }
            }

            // Check if Party is dead //Will have to change this to check for just the player if we add allies, otherwise it will work fine
            if(!bmIsAlive(_bmParty))
            {
                victory = false;
                end = true;
                Console.WriteLine("Everyone in your party has died!");
            } // Check if enemy team is dead
            else if(!bmIsAlive(_bmEnemies))
            {
                victory = true;
                end = true;
                Console.WriteLine("You have defected all the enemies.");
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

    private List<Entity> bmMakeActionOrderList()
    {
        List<Entity> listCopy = new List<Entity>(_bmAllEntities);
        List<Entity> ActionOrderList = new List<Entity>();
        while(ActionOrderList.Count < _bmAllEntities.Count)
        {
            Entity maxEntity = bmFindFastest(listCopy);
            ActionOrderList.Add(maxEntity);
            listCopy.Remove(maxEntity);
        }
        return ActionOrderList;
    }

    private static Entity bmFindFastest(List<Entity> entityList)
    {
        int maxSpeed = -1;
        Entity returnEntity = null;
        foreach(Entity entity in entityList)
        {
            if(entity.GetSpeed() > maxSpeed)
            {
                maxSpeed = entity.GetSpeed();
                returnEntity = entity;
            }
        }
        return returnEntity;
    }

    // public override void bmEnterEvent()
    // {
    //     Fight();
    // }
}