using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Buttons
{
    public class PlayerHUD : MonoBehaviour
    {
        public Button pauseButton;
        public TextMeshProUGUI hpText;
        public GameObject pauseMenu;
        public GameObject playerHUDObject;
        public int hp;

        private void Start()
        {
            hp = 30;
            hpText.text = "" + hp;
            //playerHUDObject = GameObject.Find("PlayerHud");
        }
        private void Update()
        {
            Debug.Log("hp left in the HUD " + hp);
        }

        public void PauseMenuButton()
        {
            Time.timeScale = 0;
            playerHUDObject.SetActive(false);
            pauseMenu.SetActive(true);
        }
        public void updateHP(int hpleft)
        {
            hp -= hpleft;
            hpText.text = " " + hp;

        }
    }
}
