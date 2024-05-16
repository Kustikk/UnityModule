using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehavior 
{

    protected enemy agent;

    public EnemyBehavior(enemy agent)
    {
        this.agent = agent;
    }

    abstract public void Enter();
    abstract public void Exit();
    abstract public void Update();


}
