using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaceterMovement : MonoBehaviour
{
    [SerializeField] new Rigidbody rigidbody;
    [SerializeField] float speed = 1;
    [SerializeField] float sensitivity = 10;
    [SerializeField] float rotateXDirection;
    Vector3 movementDirection;

    void Update()
    {
        TestInput();
        TestMovement();
    }

    void TestInput()
    {
        if (player.instance.gameObject != gameObject)
            return; 
        Movement();
        Rotate();

        void Movement()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            movementDirection = new Vector3(horizontal, 0, vertical);
            movementDirection = transform.TransformDirection(movementDirection);
        }
        void Rotate()
        {
            rotateXDirection = Input.GetAxis("Mouse X") * sensitivity;
        }
    }

    void TestMovement()
    {
        movement();
        rotate();

        void movement()
        {
            if (movementDirection == Vector3.zero || rigidbody == null)
                return;

            rigidbody.AddForce(movementDirection, ForceMode.VelocityChange);
        }

        void rotate()
        {
            if (rotateXDirection == 0)
                return;
            transform.transform.Rotate(Vector3.up * rotateXDirection);
            rotateXDirection = 0;
        }
    }


    public void setmovement(Vector3 movementDirection)
    {
        Vector3 movecorrected = movementDirection.normalized;
        this.movementDirection = movecorrected;
        movementDirection.y = 0;
        movementDirection.Normalize();
    }
}


