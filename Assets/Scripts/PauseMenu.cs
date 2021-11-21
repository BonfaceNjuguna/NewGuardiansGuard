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
        _pcPauseMenu();
    }

    //pause
    public void _pauseMenu()
    {
        if (GameIsPause)
        {
            Resume();
        }
        else
        {
            Pause();
        }

        if (GameOver.isGameOver == true)
        {
            pauseMenuUI.SetActive(false);
            GameIsPause = false;
        }
    }

    //pause pc
    public void _pcPauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _pauseMenu();
        }
    }

    //pause mobile
#if UNITY_ANDROID || UNITY_EDITOR
    public void _mobilePauseMenu()
    {
        _pauseMenu();
    }

#endif

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

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
