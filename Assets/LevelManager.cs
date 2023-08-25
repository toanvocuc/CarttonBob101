using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int Levels =10;
    public Button buttonPrefab;
    public Transform ContainerParent;
    private void Start()
    {
        for (int i = 0; i < Levels; i++)
        {
            Button newButton = Instantiate(buttonPrefab, ContainerParent); 
            newButton.GetComponentInChildren<TMP_Text>().text = "Level " + (i + 1); 
            
            
        }
    }
}
