﻿using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class packges : MonoBehaviour
{
    public GameObject UI_Start;
    public int menu;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            UI_Start.SetActive(false);
            menu = 1;
        }
    }
}
