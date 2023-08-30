using LvsScript;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace AllScript.LvsScript
{
    public class LevelManager : MonoBehaviour
    {
        // Start is called before the first frame update
        public int Levels =10;
        public Button buttonPrefab;
        public Transform ContainerParent;
        public static  LevelManager Instance;
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
               
            }
            else
            {
                Destroy(gameObject); 
            }

            createLv();
        }
      

        public void createLv()
        {
            for (int i = 0; i < Levels; i++)
            {
                var newButton = Instantiate(buttonPrefab, ContainerParent);
                var levelButton = newButton.AddComponent<LevelsData>();
                levelButton.Initialize(i+1);
            
            
            } 
        }
    }
}
