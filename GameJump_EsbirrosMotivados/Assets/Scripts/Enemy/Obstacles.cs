using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Buttons;

namespace Obs
{
    public class Obstacles : MonoBehaviour
    {
        PlayerHUD playerHud;

        private GameObject hud;
        public int amountOfDamage = 5;

        private void Start()
        {
            playerHud = new PlayerHUD();
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Me ha dado el barco");
                playerHud.updateHP(amountOfDamage);
            }           
        }
    }
}
