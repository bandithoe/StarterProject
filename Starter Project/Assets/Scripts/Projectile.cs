using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool isActive;


    public void Initialize()
    {
        isActive = true;
        Destroy(gameObject, 3f);
    }
    void Update()
    {
        if (isActive)
        {
            transform.position += (transform.forward * speed * Time.deltaTime);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        collision.gameObject.GetComponent<PlayerStats>().TakeDamage(20f);
        Destroy(gameObject);
    }
}
