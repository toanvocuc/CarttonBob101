using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDrawable : MonoBehaviour
{
    public SpriteMask[] spriteMasks; 
    public SpriteRenderer[] sprites;

    public void OnclickColorButton()
    {
        for (int i = 0; i < spriteMasks.Length; i++)
        {
            spriteMasks[i].gameObject.SetActive(true);
            
        }
        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].gameObject.SetActive(false);
            
        }
    }
}
