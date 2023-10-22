using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PorLevel1Script : MonoBehaviour
{
    public bool GameIsPaused = false; 
    public GameObject pauseMenuHolder;
    public GameObject pauseButton;
    public GameObject loadingScreen;
    // Start is called before the first frame update
    

    // Update is called once per frame
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
        Time.timeScale = 0.0f;
        pauseMenuHolder.SetActive(true);
        GameIsPaused = true;
        
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        pauseMenuHolder.SetActive(false);
        GameIsPaused = false;
    }

    public void PauseButton()
    {
        Time.timeScale = 0.0f;
        pauseMenuHolder.SetActive(true);
    }

}
