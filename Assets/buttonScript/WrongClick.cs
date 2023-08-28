using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongClick : MonoBehaviour
{
    public bool wrongclicked;
    public static WrongClick Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
           
        }
    }

    public void OnWrongClick()    
    {
        wrongclicked = true;
        RightClick.Instance.IsRight = false;
    }
    
}
