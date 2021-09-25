using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Core;

namespace Buttons
{
    public class PlayerHUD : MonoBehaviour
    {
        HpSystem hpsystem;

        public Button pauseButton;
        public TextMeshProUGUI hpText;
        public GameObject pauseMenu;
        public GameObject playerHUDObject;
        private int hp;

        public void Start()
        {
            //playerHUDObject = GameObject.Find("PlayerHud");
            hpsystem = GameObject.Find("player").GetComponent<HpSystem>();
        }
        private void Update()
        {           
            hp = hpsystem.numberOfPeople;
            hpText.text = "" + hp;
            Debug.Log("numberOfPeople" + hpsystem.numberOfPeople);
            Debug.Log("vida hud" + hp);
        }

        public void PauseMenuButton()
        {
            Time.timeScale = 0;
            playerHUDObject.SetActive(false);
            pauseMenu.SetActive(true);
        }
        public void updateHP(int hpleft)
        {
            hp = hp - 5;
            //hpText.text = "" + hp;
            
        }
    }
}
