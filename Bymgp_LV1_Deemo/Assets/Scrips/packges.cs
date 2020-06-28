using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class packges : MonoBehaviour
{
    public GameObject UI_Start;
    public int menu;
    public Animator STB_ani;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            STB_ani.SetBool("1", true);
            Invoke("endUIStart", 17);
        }
    }
    void endUIStart()
    {

        UI_Start.SetActive(false);
    }
}
