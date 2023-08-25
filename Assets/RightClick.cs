using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightClick : MonoBehaviour
{
    public static RightClick Instance;
    public bool IsRight ;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
           
        }
       
    }

    public void OnclickRightButton()
    {   IsRight = true;
        StartCoroutine(DelayCoroutine1Second());
          
    }
    private IEnumerator DelayCoroutine1Second()
    {
        // Wait for 1 seconds
        yield return new WaitForSeconds(1f);
       
    }
}
