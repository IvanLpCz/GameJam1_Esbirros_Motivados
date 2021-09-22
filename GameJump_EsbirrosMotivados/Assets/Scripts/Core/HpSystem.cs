using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Obs;

namespace Core
{
    public class HpSystem : MonoBehaviour
    {
        public float numberOfPeople = 100;
        public Canvas DeathPanel;
        Obstacles obstacles;
        

        private void Update()
        {
            if(numberOfPeople <= 0)
            {
                DeathPanel.enabled = true;
            }
            else
            {
                DeathPanel.enabled = false;
            }
            Debug.Log("cantidad de gente restante " + numberOfPeople);
        }
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Obstacle"))
            numberOfPeople = numberOfPeople - obstacles.amountOfDamage;
        }
    }
}
