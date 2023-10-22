using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class PauseMenuScript : MonoBehaviour
{
    
    public bool GameIsPaused = false;

   
    public GameObject pauseMenu;
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

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = 1.0f;
            loadingScreen.SetActive(true);
            Invoke("LoadStart", 0.9f);
        }

    }

    public void OnPause()
    {
        pauseMenu.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0.0f;
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
        GameIsPaused = false;
    }

    public void LevelSelect()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadLevelSelect", 0.9f);
        pauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadMenu", 0.9f);
        pauseMenu.SetActive(false);
    }

    // For Start Button
    public void StartGame()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadStart", 0.9f);
    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        pauseMenu.SetActive(false);
        Invoke("LoadRestart", 0.9f);
    }


    public void ExitButton()
    {
        Application.Quit();
    }

    void LoadStart()
    {
        level1Canvas.SetActive(false);
    }

    void LoadRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void LoadMenu()
    {
        SceneManager.LoadScene("LMainMenuScene");
    }

    void LoadLevelSelect()
    {
        SceneManager.LoadScene("LLevelSelectScene");
    }



}
