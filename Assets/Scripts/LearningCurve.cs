using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LearningCurve : MonoBehaviour
{
    public Transform camTransform;
    public GameObject directionLight;
    public Transform lightTransform;
    private void Start()
    {
       // directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);
        Character hero = new Character();
        Character hero2 = hero;
        hero2.name = "Vlad ebaniy";
        
     //   hero.PrintStatsInfo();
       // hero2.PrintStatsInfo();
       // hero2.Reset();
       // hero2.PrintStatsInfo();
        //Weapon huntingBow = new Weapon("HuntingBow", 105);
       // huntingBow.PrintWeaponstats();
       Weapon hutingBow = new Weapon("HuntingBow", 105);
        Paladin knight = new Paladin("sir Arthur" , hutingBow );
        knight.PrintStatsInfo();
        hutingBow.PrintWeaponstats();
       // Character heroine = new Character("Aghata");
       //  heroine.PrintStatsInfo();
       




    }
}