using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Buttons
{
    public class ButtonsGameOver : MonoBehaviour
    {
        public Button tryAgain, toMenu;
        Scene thisScene;

        private void Start()
        {
            thisScene = SceneManager.GetActiveScene();
        }
        public void TryAgain()
        {
            SceneManager.LoadScene(thisScene.name);
        }
        public void ToMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}