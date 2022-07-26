using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
    private Material _material;
    private PlayerBehavior _player;

    private void Awake()
    {
        _material = GetComponent<Material>();
    }

    private void Start()
    {
        _player = FindObjectOfType<PlayerBehavior>();

    }

    void Update()
    {
        if (IsCBetweenAB(Camera.main.transform.position , _player.transform.position , transform.position))
        {   
            gameObject.SetActive(false);
            
        }
        else
        {
            gameObject.SetActive(true);
        }
        
    }

  private  bool IsCBetweenAB(Vector3 A, Vector3 B, Vector3 C)
    {
        return Vector3.Dot((B - A).normalized, (C - B).normalized) < 0f &&
               Vector3.Dot((A - B).normalized, (C - A).normalized) < 0f;
    }
}