using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void StartGame(int sceneNr)
    {
        SceneManager.LoadScene(sceneNr);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Pause(int sceneNr)
    {
        SceneManager.LoadScene(sceneNr);
    }
}
