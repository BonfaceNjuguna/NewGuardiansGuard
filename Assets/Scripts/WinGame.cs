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
        if (score.instance.scores == score.instance.highscore)
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

    //proceed to level 2
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

    //restart game after winning
    public void RestartWinGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 0;
    }

    //main menu
    public void RestartMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }


    //quit game
    public void QuitWinGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
