using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehaviorpursuit : EnemyBehavior
{

    public enemybehaviorpursuit(enemy agent ) : base(agent)
    {

    }
   
    public override void Enter()
    {
        Debug.Log("enter pursuit behavior");
    }

    public override void Exit()
    {
        Debug.Log("exit pursuit behavior");
    }

    public override void Update()
    {
        Debug.Log("update pursuit behavior");
    }
}
