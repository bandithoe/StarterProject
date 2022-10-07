using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.GetChild(3).GetComponent<PlayerWeapon>().ActivateWeapon();
        Destroy(gameObject);
    }
}
