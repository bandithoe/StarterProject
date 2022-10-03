using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    public Transform shotPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = shotPosition.position;
            newBullet.GetComponent<Bullet>().Initialize();
        }
    } 
}
