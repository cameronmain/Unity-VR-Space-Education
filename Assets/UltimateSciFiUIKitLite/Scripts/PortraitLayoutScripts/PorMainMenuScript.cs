using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PorMainMenuScript : MonoBehaviour
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
        SceneManager.LoadScene("PMainMenuScene");
    }

    void LoadLevel01()
    {
        SceneManager.LoadScene("PLevel1Scene");
    }

    void LoadCredits()
    {
        SceneManager.LoadScene("PCreditsScene");
    }

    void LoadHelp()
    {
        SceneManager.LoadScene("PHelpScene");
    }

    void LoadQuit()
    {
        SceneManager.LoadScene("PQuitScene");
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
        Invoke("PMainMenuScene", 0.9f);
    }

    public void PlayGame()
    {
        Time.timeScale = 1.0f;
		loadingScreen.SetActive (true);
        Invoke("LoadLevel01", 0.9f);
    }

    public void Replay()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadLevel01", 0.9f);
    }

    public void Help()
    {
        Time.timeScale = 1.0f;
 		loadingScreen.SetActive (true);
        Invoke("LoadHelp", 0.9f);
    }

    public void Credits()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadCredits", 0.9f);
    }

    public void Quit()
    {
        Time.timeScale = 1.0f;
        loadingScreen.SetActive(true);
        Invoke("LoadQuit", 0.9f);
    }



}
