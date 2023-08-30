using UnityEngine;
using UnityEngine.SceneManagement;

namespace AllScript.buttonScript
{
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
}