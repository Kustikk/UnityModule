using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : character
{
    EnemyBehavior BehaviorActive;
    // Start is called before the first frame update
    void Start()
    {

        StartBehavior();
    }

    // Update is called once per frame
    void Update()
    {
        BehaviorActive?.Update();
    }

     void StartBehavior()
    {
        BehaviorActive = new EnemyBehaviorChilling(this);
    }
    public void SetBehavior(EnemyBehavior newBehavior)

     { 
        if(newBehavior == null)
            return;


        BehaviorActive?.Exit();
        BehaviorActive = newBehavior;   
        BehaviorActive.Enter();

    }

}
