﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [HideInInspector]
    public bool GameRun;

    public GameObject CanvasStart;
    public GameObject CanvasEnd;

    public PostProcessingBehaviour PP;
    public PostProcessingProfile PPProfile;
    public PostProcessingProfile PPProfile_Paused;

    private void Start()
    {
        GameRun = false;
        PP.profile = PPProfile_Paused;
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
        
        //if (Input.GetKey(KeyCode.Z))
        //    StartGame();
        //else if (Input.GetKey(KeyCode.X))
        //    EndGame();
        //else if (Input.GetKey(KeyCode.C))
        //    RestartGame();
    }

    public void StartGame()
    {
        GameRun = true;
        CanvasStart.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        PP.profile = PPProfile;
    }

    public void EndGame()
    {
        GameRun = false;
        CanvasEnd.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        PP.profile = PPProfile_Paused;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Scenes/Game");
    }

}
