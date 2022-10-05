using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    [SerializeField] private float turnSpeed;
    [SerializeField] private Rigidbody characterBody;
    private float horizontalInput;
    private float verticalInput;
    

    void Update()
    {
        Move();
        Sprint();
        Jump();
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        if (horizontalInput != 0)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }

        if (verticalInput != 0) 
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
        }
    }
    private void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            speed += 3f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)) 
        {
            speed -= 3f;
        }   
    }
    private void Jump() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && isTouchingFLoor()) 
        {
            characterBody.AddForce(Vector3.up * 300f);   
        }
    }
    private bool isTouchingFLoor()
    {
        //ground check so the character doesnt jump forever and only jumps after its hit the ground
        RaycastHit hit;
        return Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1f);
    }
    
}

