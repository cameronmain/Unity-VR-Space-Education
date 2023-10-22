using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class QuitMenuScript : MonoBehaviour
{

	public GameObject loadingScreen;

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

	public void Yes()
	{
		Application.Quit();
	}
	
	public void No()
	{
		loadingScreen.SetActive(true);
		Invoke("LoadMMenu", 0.9f);
	}
}
