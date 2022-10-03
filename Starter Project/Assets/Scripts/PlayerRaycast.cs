using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{

    public PlayerWeapon playerWeapon;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit result;
            bool thereWasHit = Physics.Raycast(playerWeapon.shotPosition.position, transform.forward, out result, Mathf.Infinity);

            //This line is not needed for the ray to work, its just a visualization to see the ray
            Debug.DrawRay(playerWeapon.shotPosition.position, transform.forward * 50f, Color.red, 0.05f);

            if (thereWasHit)
            {
                result.collider.gameObject.GetComponent<MeshRenderer>().material.color = GetRandomColor();
            }
            // PickupManager.GetInstance()
        }
    }

    private Color GetRandomColor()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        return color;
    }
}
