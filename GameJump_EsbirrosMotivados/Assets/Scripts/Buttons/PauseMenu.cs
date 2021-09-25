using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class PauseMenu : MonoBehaviour
    {
        public Button continueButton, restartButton, exitButton;
        Scene thisScene;
        public GameObject playerHud;
        public GameObject PauseMenuObject;
       
        public void Start()
        {
            thisScene = SceneManager.GetActiveScene();
            //PauseMenuObject = GameObject.Find("MenuInGameCanvas");
        }
        public void ContinueButton()
        {
            Time.timeScale = 1;
            PauseMenuObject.SetActive(false);
            playerHud.SetActive(true);
        }
        public void RestartButton()
        {
            SceneManager.LoadScene(thisScene.name);
            Time.timeScale = 1;
        }
        public void ExitButton()
        {
            SceneManager.LoadScene("MainMenu");
            Time.timeScale = 1;
        }
    }

}