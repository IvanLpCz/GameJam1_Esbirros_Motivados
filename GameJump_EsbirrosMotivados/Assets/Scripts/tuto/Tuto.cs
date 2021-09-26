using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Tuto
{
    public class Tuto : MonoBehaviour
    {
        public GameObject tuto;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                tuto.SetActive(false);
            }
                
        }
    }
}
