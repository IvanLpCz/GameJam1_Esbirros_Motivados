using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class BounceBack : MonoBehaviour
    {
        private Rigidbody playerRB;
        public float powerPuss = 10;
        private AudioSource playerAudio;
        public AudioClip bonkSound;
        public AudioClip bellSound;

        private void Start()
        {
            playerRB = GetComponent<Rigidbody>();
            playerAudio = GetComponent<AudioSource>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Obstacle"))
            {
                playerRB.AddForce(-transform.forward * powerPuss, ForceMode.Impulse);
                playerAudio.PlayOneShot(bonkSound, 1.0f);
            }
            if (other.gameObject.CompareTag("boya"))
            {
                playerAudio.PlayOneShot(bellSound, 1.0f);
            }
        }
    }

}