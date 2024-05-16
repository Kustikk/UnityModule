using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemybehaviorcombat : EnemyBehavior
{


    CharaceterMovement charactermovement;
    public enemybehaviorcombat(enemy agent) : base(agent)
    {

    }

    public override void Enter()
    {
        Debug.Log("enter combat behavior");
    }

    public override void Exit()
    {
        Debug.Log("exit combat behavior");
    }

    public override void Update()
    {
        Debug.Log("update combat behavior");

        Vector3 targetpoint = player.instance.transform.position;

        charactermovement ??= agent.GetComponent<CharaceterMovement>();

        movement();

        void movement()
        {
            NavMeshPath path = new NavMeshPath();

            NavMesh.CalculatePath(agent.transform.position, targetpoint, NavMesh.AllAreas, path);

            if (path != null && path.corners.Length > 1)
            {
                Vector3 vector = path.corners[1] - path.corners[0];
                if(vector.magnitude > 1f || path.corners.Length > 2)
                {
                    charactermovement.setmovement(vector);

                }
                else
                {
                    charactermovement.setmovement(Vector3.zero);
                }
            }
        }

        void attack()
        {
            float distance = (targetpoint - agent.transform.position).magnitude;

            if (distance > 2)
                return;

            player.instance.SetDamage(1 * Time.deltaTime);
        }
    }
}
