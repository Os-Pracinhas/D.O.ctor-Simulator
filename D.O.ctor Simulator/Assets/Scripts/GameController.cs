﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject nameDr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void ButtonStart()
    {
        nameDr.SetActive(true);
    }
}
