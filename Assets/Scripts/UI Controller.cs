using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickQuit()
    {
        Application.Quit();
        Debug.Log("Quit button pressed");
    }
}
