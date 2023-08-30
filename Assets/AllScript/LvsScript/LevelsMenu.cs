using UnityEngine;
using UnityEngine.SceneManagement;

namespace AllScript.LvsScript
{
    public class LevelsMenu : MonoBehaviour
    {
        public void LoadlevelMenu()
        {
            SceneManager.LoadScene("LevelScenes");
        }
   
    }
}
