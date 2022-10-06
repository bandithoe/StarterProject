using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    public GameObject weapon;
    public Transform shotPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = shotPosition.position;
            newBullet.transform.rotation = gameObject.transform.rotation;
            newBullet.GetComponent<Bullet>().Initialize();
        }
    }

    public void ActivateWeapon()
    {
        weapon.SetActive(true);
    }
}
