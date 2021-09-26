using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class ButtonCreddits : MonoBehaviour
    {
        public Button menuButton;

        public void MenuButton()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}