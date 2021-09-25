using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class PopEndPhase : MonoBehaviour
    {
        public GameObject endPhaseMenu;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
                endPhaseMenu.SetActive(true);
        }
    }
}
