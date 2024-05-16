using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaceterMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody rigidbody;
    [SerializeField]
    float speed = 1;
    [SerializeField]
    float sensitivity = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TestInput();
    }

    void TestInput()
    {
        if (rigidbody == null)
            return;

        Movement();
        Rotate();



    void Movement()
          {
              float vertical = Input.GetAxis("Vertical");
              float horisontal = Input.GetAxis("Horizontal");

              Vector3 movementDirection = new Vector3(horisontal, 0, vertical);
              movementDirection = transform.TransformDirection(movementDirection);

              rigidbody.AddForce(movementDirection, ForceMode.VelocityChange);

          }
        void Rotate()
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;

            transform.Rotate(Vector3.up * mouseX);
        }
    }
}