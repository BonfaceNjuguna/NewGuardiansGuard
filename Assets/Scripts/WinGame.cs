using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public GameObject winGameUI;
    public static bool isWinGame = false;


    void Update()
    {
        if (score.instance.scores > 4)
        {
            winGame();
        }
    }

    public void winGame()
    {
        winGameUI.SetActive(true);
        Time.timeScale = 0f;

        isWinGame = true;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
