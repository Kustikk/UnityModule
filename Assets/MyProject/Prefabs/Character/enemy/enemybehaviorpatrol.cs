using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehaviorpatrol : EnemyBehavior
{
    public enemybehaviorpatrol(enemy agent) : base(agent)
    {

    }

    public override void Enter()
    {
        Debug.Log("enter patrol behavior");
    }

    public override void Exit()
    {
        Debug.Log("exit patrol behavior");
    }

    public override void Update()
    {
        Debug.Log("update patrol behavior");
    }
}
