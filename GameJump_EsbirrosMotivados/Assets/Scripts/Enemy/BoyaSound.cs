using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obs
{
    public class BoyaSound : MonoBehaviour
    {
        private AudioSource playerAudio;
        public AudioClip bellSound;
        private void Start()
        {
            playerAudio = GetComponent<AudioSource>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                playerAudio.PlayOneShot(bellSound, 1.0f);
            }
        }
    }
}