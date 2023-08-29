using System.Collections;
using System.Collections.Generic;
using LvsScript;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
   public int nextSceneLoad;


   void Start()
   {
      nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 2;
   }

   public void OnclickNextLevel()
   {
      //Move to next level
      SceneManager.LoadScene(nextSceneLoad-1);
     
      //Setting Int for Index
      if (nextSceneLoad >= PlayerPrefs.GetInt("levelAt"))
      {
         PlayerPrefs.SetInt("levelAt", nextSceneLoad );
         Debug.Log(PlayerPrefs.GetInt("levelAt", nextSceneLoad));
      }
   }
   
}