using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterControls : MonoBehaviour
{
    [SerializeField] private float sensX;
    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody characterBody;

    float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

        void Update()
    {
        Vector3 mov = Vector3.zero;

        if (Input.GetAxis("Horizontal") != 0)
        {
            mov += Vector3.right * speed * Input.GetAxis("Horizontal");
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            mov += Vector3.forward * speed * Input.GetAxis("Vertical");
        }
        mov = new(mov.x, 0, mov.z);
        Debug.Log(mov);
        //mov.Normalize();
        // transform.position = transform.position+(mov * Time.deltaTime);   
        transform.Translate(mov * speed * Time.deltaTime);


        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;


        yRotation += mouseX;

        transform.rotation = Quaternion.Euler(0, yRotation, 0);

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
