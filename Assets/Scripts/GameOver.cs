using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverUI;
    public static bool isGameOver = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "motherearth" )
        {
            gameOver();
            Destroy(gameObject);
        }
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0;

        isGameOver = true;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");

        isGameOver = false;
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");

        isGameOver = false;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
