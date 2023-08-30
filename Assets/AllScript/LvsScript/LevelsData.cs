using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LvsScript
{
    public class LevelsData : MonoBehaviour
    { 
        private int levelIndex;
    
        public void Initialize(int levelNumber)
        {
            levelIndex = levelNumber;
            TMP_Text buttonText = GetComponentInChildren<TMP_Text>();
            buttonText.text = "Level " + (levelIndex);
            Button buttonComponent = GetComponent<Button>();
            buttonComponent.onClick.AddListener(OnButtonClick);
        }

        public void OnButtonClick()
        {
            SceneManager.LoadScene("Lv" + levelIndex);
        }
    }
}
