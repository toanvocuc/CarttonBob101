
using UnityEngine;
using UnityEngine.UI;

namespace LvsScript
{
    public class LevelsGamplayUnlock : MonoBehaviour
    {
        public RectTransform Parent;
        public Button[] lvlButtons;

        // Start is called before the first frame update
        void Start()
        {    
            lvlButtons = Parent.GetComponentsInChildren<Button>();
            Debug.Log(lvlButtons.Length);
            int levelAt = PlayerPrefs.GetInt("levelAt", 2);
            
            for (int i = 0; i < lvlButtons.Length; i++)
            {
                if (i + 2 > levelAt)
                    lvlButtons[i].interactable = false;
            }
        }
        
    }
}
