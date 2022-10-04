using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("lol"); 
        other.GetComponent<PlayerStats>().GetHeal(20f);
        Destroy(gameObject);
    }
    
}
 