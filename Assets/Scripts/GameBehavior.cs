using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public bool showWinScreen = false;
    public bool showLossScreen = false;
    public string labelText = "Collect all 4 items and win your freedom";
    public int maxItems = 4;
    private int _itemsCollected = 0;

    public int Items
    {
        get { return _itemsCollected; }

        set
        {
            _itemsCollected = value;
            if (_itemsCollected >= maxItems)
            {
                labelText = "You have found all the items";
                showWinScreen = true;

                Time.timeScale = 0f;
            }
            else
            {
                labelText = "Item found , only" + (maxItems - _itemsCollected) + "more to go";
            }

            Debug.LogFormat("Items: {0}", _itemsCollected);
        }
    }

    private int _playerHP = 3;

    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            if (_playerHP <= 0)
            {
                labelText = "You want another life with that?";
                showLossScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                labelText = "Ouch...That's got hurt.";
            }

            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 150, 50),
            "Player health:" + _playerHP);
        GUI.Box(new Rect(50, 100, 150, 60),
            "Items Collected: " + _itemsCollected);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100,
                    Screen.height / 2 - 50, 200, 100), "YOU WON"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1.0f;
            }
        }

        if (showLossScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100,
                    Screen.height / 2 - 50, 200, 100), "You lose..."))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1.0f;
            }
        }
    }
}