using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public GameObject winGameUI;
    public static bool isWinGame = false;

    void Start()
    {
        Time.timeScale = 1;
    }
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
        Time.timeScale = 0;

        isWinGame = true;
    }

    public void RestartWinGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 0;
    }

    public void RestartMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void QuitWinGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
