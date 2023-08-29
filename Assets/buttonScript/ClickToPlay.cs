using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickToPlay : MonoBehaviour
{
    public static ClickToPlay Instance;
    public GameObject menu;

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
        menu.SetActive(false);
    }
}
