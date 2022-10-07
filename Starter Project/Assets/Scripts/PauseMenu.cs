using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public bool gameIsPaused;
    public GameObject pause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
                /*Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;*/
            }
            else
            {
                Pause();
                /*Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;*/
            }
        }
    }

    private void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    private void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
}
