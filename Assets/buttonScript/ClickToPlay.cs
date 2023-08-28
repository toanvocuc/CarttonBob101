using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPlay : MonoBehaviour
{
    public static ClickToPlay Instance;
    

    private void Awake()
    {
        Instance = this;
       
    }

    private void Start()
    {
        PlayerController.Instance.StopMoving();
    }

    public void OnClickToPlay()
    {   
       
        gameObject.SetActive(false);
        PlayerController.Instance.StartMoving();
    }
}
