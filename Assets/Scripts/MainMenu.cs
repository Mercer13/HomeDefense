using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string nextLevelName;

    public void PlayGame()
    {
        SceneManager.LoadScene(nextLevelName);
    }

    public void ExitGame()
    {
        Debug.Log("Game is closed");
        Application.Quit();
    }
}
