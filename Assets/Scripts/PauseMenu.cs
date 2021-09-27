using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;


    void Start()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (GameOver.isGameOver == true)
        {
            pauseMenuUI.SetActive(false);
            GameIsPause = false;
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

        GameIsPause = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;

        GameIsPause = true;
    }

    public void NewGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
