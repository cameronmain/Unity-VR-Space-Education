using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
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
            Invoke("LoadMMenu", 0.9f);
        }
    }

    void LoadMMenu()
    {
        SceneManager.LoadScene("LMainMenuScene");
    }

    public void BackButton()
    {
        loadingScreen.SetActive(true);
        Invoke("LoadMMenu", 0.9f);
    }
}
