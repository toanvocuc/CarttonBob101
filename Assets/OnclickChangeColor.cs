using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnclickChangeColor : MonoBehaviour
{
    public GameObject yealowBackground;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Camera.main != null)
            {
                Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

                if (hit.collider != null && hit.collider.gameObject == gameObject)
                {
                    Debug.Log("Object Clicked: " + gameObject.name);
                    yealowBackground.SetActive(true);
                }
            }
        }
    }
    
}
