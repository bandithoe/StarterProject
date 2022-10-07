using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    private static PickupManager instance;
    [SerializeField] private GameObject pickupPrefab;
    [SerializeField] private CurrentPlayerActive switchPlayer;
    [SerializeField] private PlayerStats[] playerStats;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static PickupManager GetInstance()
    {
        return instance;
    }


    public void Drop()
    {
        // StartCoroutine(WaitForSwitch());
        GameObject newPickup = Instantiate(pickupPrefab);
        newPickup.transform.position = new Vector3(Random.Range(0f, 10f), 1f, Random.Range(0f, 10f));
    }

    // private IEnumerator WaitForSwitch()
    // {
    //     yield return new WaitForSeconds(3);
    //     switchPlayer.PlayerSwitch();
    // }
}