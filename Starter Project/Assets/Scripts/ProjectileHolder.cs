using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHolder : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    public Transform shotPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(projectilePrefab);
            newBullet.transform.position = shotPosition.position;
            newBullet.transform.rotation = gameObject.transform.rotation;
            newBullet.GetComponent<Projectile>().Initialize();
        }
    }
}
