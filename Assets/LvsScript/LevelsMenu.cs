using UnityEngine;
using UnityEngine.SceneManagement;

namespace LvsScript
{
    public class LevelsMenu : MonoBehaviour
    {
        public void LoadlevelMenu()
        {
            SceneManager.LoadScene("LevelScenes");
        }
   
    }
}
