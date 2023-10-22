using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PorPauseMenuScript : MonoBehaviour
{
    public bool GameIsPaused = false;


    public GameObject pauseMenu;
    public GameObject pauseButton;
    public GameObject playButton;
    public GameObject level1Canvas;
    public GameObject loadingScreen;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                OnPause();
            }

        }

    }

    public void OnPause()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        GameIsPaused = true;
        Time.timeScale = 0.0f;
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        GameIsPaused = false;
    }

    public void MMenu()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadMenu", 0.9f);
        pauseMenu.SetActive(false);
        pauseButton.SetActive(false);
    }

    public void StartGame()
    {
        level1Canvas.SetActive(false);
        playButton.SetActive(false);
    }

    public void LevelSelect()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadLevelSelect", 0.9f);
        pauseMenu.SetActive(false);
        pauseButton.SetActive(false);
    }

    public void Replay()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        pauseMenu.SetActive(false);
        pauseButton.SetActive(false);
        Invoke("LoadReplay", 0.9f);
    }


    public void ExitButton()
    {
        Application.Quit();
    }

    void LoadReplay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void LoadMenu()
    {
        SceneManager.LoadScene("PMainMenuScene");
    }

    void LoadLevelSelect()
    {
        SceneManager.LoadScene("PLevelSelectScene");
    }
}
