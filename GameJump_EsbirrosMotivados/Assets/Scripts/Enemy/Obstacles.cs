using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obs
{
    public class Obstacles : MonoBehaviour
    {
        public float amountOfDamage = 5;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Me ha dado el barco");
            }           
        }
    }
}
