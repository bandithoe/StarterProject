using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class CurrentPlayerActive : MonoBehaviour
{

    [SerializeField] private GameObject playerOne;
    [SerializeField] private GameObject playerTwo;

    private PlayerControls playerControls;
    // Start is called before the first frame update
    void Start()
    {
        playerOne.GetComponent<PlayerControls>().enabled = true;
        playerTwo.GetComponent<PlayerControls>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Switch();
    }

    private void Switch()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerOne.GetComponent<PlayerControls>().enabled = true;
            playerTwo.GetComponent<PlayerControls>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerTwo.GetComponent<PlayerControls>().enabled = true;
            playerOne.GetComponent<PlayerControls>().enabled = false;
        }
    }
}