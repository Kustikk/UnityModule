using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehaviordeath : EnemyBehavior
{
    public enemybehaviordeath(enemy agent) : base(agent)
    {

    }

    public override void Enter()
    {
        Debug.Log("enter death behavior");
    }

    public override void Exit()
    {
        Debug.Log("exit death behavior");
    }

    public override void Update()
    {
        Debug.Log("update death behavior");
    }
}
