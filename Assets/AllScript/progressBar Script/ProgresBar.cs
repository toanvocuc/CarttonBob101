using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgresBar : MonoBehaviour
{ public static ProgresBar Instance;
  public Slider slider;
  private void Awake()
  {
      slider.value = 0;
      if (Instance == null)
      {
          Instance = this;
      }
      else
      {
          Destroy(gameObject); 
               
      }
            
  }
  public void SetMaxValue(float maxValueProgress)
  {
      slider.maxValue = maxValueProgress;
  }

  public void ChangeValue()
  {
      slider.value += 1;
  }
}
 
