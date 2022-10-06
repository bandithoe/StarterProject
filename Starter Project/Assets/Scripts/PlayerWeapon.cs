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


    void Start()
    { 
        weapon.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = shotPosition.position;
            newBullet.transform.rotation = gameObject.transform.rotation;
            newBullet.GetComponent<Bullet>().Initialize();
        }
    } 
}
