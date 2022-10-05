using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float speed;
    private bool isActive;


    public void Initialize()
    {
        isActive = true;
    }
    void Update()
    {
        if (isActive)
        {
            transform.position += (transform.forward * speed * Time.deltaTime);
        }
    }
    
    private void OnCollisionEnter(Collision specificCollision)
    {
        Debug.Log(specificCollision);
        if (specificCollision.gameObject.CompareTag("Cube"))
        { 
            specificCollision.gameObject.GetComponent<PlayerStats>().TakeDamage(20f);
            Destroy(gameObject); 
        }
        
    }
}
