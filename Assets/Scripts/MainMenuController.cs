using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void BacktoMain()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Thanks for Playing!");
    }

    public void HowtoPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Exit()
    {
        Application.Quit();
    }

}