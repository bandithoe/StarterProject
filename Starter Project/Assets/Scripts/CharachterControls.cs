using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterControls : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody characterBody;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0) 
        {
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed + 3f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed - 3f;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        
    }

    private void Jump()
    {
        characterBody.AddForce(Vector3.up * 300);
    }
}
 