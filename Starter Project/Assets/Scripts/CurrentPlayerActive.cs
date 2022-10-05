using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class CurrentPlayerActive : MonoBehaviour
{

    [SerializeField] private GameObject playerOne;
    [SerializeField] private GameObject playerTwo;

    public PlayerControls playerOneControls;
    public PlayerControls playerTwoControls;

    public static PlayerControls activePlayer;

    // Start is called before the first frame update
    void Start()
    {
        playerOneControls = playerOne.GetComponent<PlayerControls>();
        playerTwoControls = playerTwo.GetComponent<PlayerControls>();

        playerOneControls.enabled = true;
        playerTwoControls.enabled = false;

        activePlayer = playerOneControls;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PlayerSwitch();
        }
        
    }

    private void PlayerSwitch()
    {

        if (activePlayer != playerOneControls)
        {
            Debug.Log("player 1 activation");
            playerOneControls.enabled = true;
            playerTwoControls.enabled = false;

            activePlayer = playerOneControls;
        }

        else if (activePlayer != playerTwoControls)
        {
            Debug.Log("player 2 activation");
            playerOneControls.enabled = false;
            playerTwoControls.enabled = true;

            activePlayer = playerTwoControls;
        }

        CameraController.CamController.CameraSwitchPlayer(activePlayer.gameObject);
    }
}