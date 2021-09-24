using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Buttons
{
    public class MainMenuButtons : MonoBehaviour
    {
        public Button play, credits, exit;

        public void PlayGame()
        {
            SceneManager.LoadScene("Level1");
        }
        public void CreditsScene()
        {
            SceneManager.LoadScene("Credits");
        }
        public void ExitGame()
        {
            Application.Quit();
        }
    }

}