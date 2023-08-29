using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelShow : MonoBehaviour
{
    public TMP_Text nextLevel;
    private TMP_Text currentLevel;
    public TMP_Text CurretLevelMenu;

    private void Awake()
    {
        CurretLevelMenu.text = "LV: "+ (SceneManager.GetActiveScene().buildIndex);
    }

    void Start()
    {
        currentLevel = gameObject.GetComponent<TMP_Text>();
        currentLevel.text= (SceneManager.GetActiveScene().buildIndex ).ToString();
       
        nextLevel.text = (SceneManager.GetActiveScene().buildIndex + 1).ToString();
    }

   
}
