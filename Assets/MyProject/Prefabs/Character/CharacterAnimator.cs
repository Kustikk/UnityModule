using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{

    [SerializeField]
    Animator animator;
    [SerializeField]
    Rigidbody rigidbody;

    const string keyAnimForwardBack = "ForwardBack";
    const string keyAnimLeftRight = "LeftRight";

    Vector3 velocityNow;
    Vector3 velocityNeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TestAnimation();
    }

    void TestAnimation()
    {
        Movement();

        void Movement()
        {
            if (rigidbody.velocity != Vector3.zero)
            {
                velocityNeed = rigidbody.velocity;
            }
            velocityNow += (velocityNeed - velocityNow) * Time.deltaTime * 10;

            Vector3 animatorDirection = velocityNow;
            animatorDirection = transform.InverseTransformDirection(animatorDirection);

            animator.SetFloat(keyAnimForwardBack, animatorDirection.z);
            animator.SetFloat(keyAnimLeftRight, animatorDirection.x);
        }
    }
}
