using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("lol");
        other.GetComponentInChildren<PlayerWeapon>().GameObject().SetActive(true);
        Destroy(gameObject);
    }
}
