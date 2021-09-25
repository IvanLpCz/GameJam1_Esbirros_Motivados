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
        public Button pauseButton;
        public Text hpText;
        HpSystem hpsystem;

        private void Start()
        {
            hpsystem = new HpSystem();
        }


    }
}
