using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Obs;

namespace Core
{
    public class HpSystem : MonoBehaviour
    {
        public int numberOfPeople = 30;
        public Canvas DeathPanel;
        Obstacles obstacles;

        public void Start()
        {
           obstacles = new Obstacles();
        }


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
            //Debug.Log("cantidad de gente restante " + numberOfPeople);
        }
        public void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Obstacle"))
            numberOfPeople = numberOfPeople - obstacles.amountOfDamage;
        }
    }
}
