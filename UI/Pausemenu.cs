﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour {

    public static bool GamePaused = false;

    public GameObject PauseMenuUI;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
    public void LoadMenu()
    {
        Debug.Log("Loading menu");
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
    }
}
