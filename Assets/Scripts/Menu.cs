using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    private int _indexSceneGame = 1;
    public void StartGame()
    {
        SceneManager.LoadScene(_indexSceneGame);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
