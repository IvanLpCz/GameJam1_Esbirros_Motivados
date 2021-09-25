using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class PopEndPhase : MonoBehaviour
    {
        public GameObject endPhaseMenu;
        MoveForward moveforward;

        private void Start()
        {
            moveforward = GameObject.Find("player").GetComponent<MoveForward>();
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                endPhaseMenu.SetActive(true);
                moveforward.topSpeed = 0;
            }
                
        }
    }
}
