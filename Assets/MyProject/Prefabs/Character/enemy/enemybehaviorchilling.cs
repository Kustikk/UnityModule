using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemyBehaviorChilling : EnemyBehavior
{
    public EnemyBehaviorChilling(enemy agent) : base(agent)
    {

    }

    public override void Enter()
    {
        Debug.Log("enter chilling behavior");
    }

    public override void Exit()
    {
        Debug.Log("exit chilling behavior");
    }

    public override void Update()
    {
        Debug.Log("update chilling behavior");

        lookingplayer();

        void lookingplayer()
        {
            Vector3 playerpos = player.instance.transform.position;
            Vector3 toplayer = playerpos - agent.transform.position;

            float distance = toplayer.magnitude;

            float distancemax = 5;
            if (distance > distancemax)
                return;


            RaycastHit hit;
            Ray ray = new Ray(agent.transform.position, toplayer.normalized);
            Physics.Raycast(ray, out hit, distancemax);

            if (hit.collider == null)
                return;

            if (hit.collider.gameObject != player.instance.gameObject)
                return;

            enemy enemy = agent.GetComponent<enemy>();
            enemy.SetBehavior(new enemybehaviorcombat(agent));
        }
    }
}
