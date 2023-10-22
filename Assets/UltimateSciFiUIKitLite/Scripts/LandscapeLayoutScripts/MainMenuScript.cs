using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour 
{
    
    public GameObject loadingScreen;

    void Start()
    {
        loadingScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            loadingScreen.SetActive(true);
            Invoke("LoadQuit", 0.9f);
        }
    }

    void LoadMMenu()
    {
        SceneManager.LoadScene("LMainMenuScene");
    }

    void LoadLevel01()
    {
        SceneManager.LoadScene("LLevel1Scene");
    }

    void LoadLevelSelect()
    {
        SceneManager.LoadScene("LLevelSelectScene");
    }

    void LoadCredits()
    {
        SceneManager.LoadScene("LCreditsScene");
    }

    void LoadHelp()
    {
        SceneManager.LoadScene("LHelpScene");
    }

    void LoadQuit()
    {
        SceneManager.LoadScene("LQuitScene");
    }

    void LoadLScreen()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
    }

    public void MMenu()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadMMenu", 0.9f);
    }

    public void NewGame()
	{
		Time.timeScale = 1.0f;
		loadingScreen.SetActive (true);
        Invoke("LoadLevel01", 0.9f);
    }

    public void LoadGame()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadLevelSelect", 0.9f);
    }

    public void Replay()
	{
		Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadLevel01", 0.9f);
    }

    public void Credits()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadCredits", 0.9f);
    }

    public void Help()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadHelp", 0.9f);
    }

    public void Quit()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadQuit", 0.9f);
    }

    public void ExitYes()
    {
        Time.timeScale = 1.0f;
        Application.Quit();
    }

     public void ExitNo()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LMainMenuScene", 0.9f);
    }

}

