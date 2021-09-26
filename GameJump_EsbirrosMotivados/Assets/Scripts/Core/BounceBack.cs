using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class BounceBack : MonoBehaviour
    {
        private Rigidbody playerRB;
        public float powerPuss = 10;

        private void Start()
        {
            playerRB = GetComponent<Rigidbody>(); 
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Obstacle"))
            {
                playerRB.AddForce(transform.forward * powerPuss, ForceMode.Impulse);
            }
        }
    }

}