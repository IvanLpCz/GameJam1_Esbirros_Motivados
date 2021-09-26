using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Core;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class EndGameButton : MonoBehaviour
    {
        public GameObject endGameCanvas;
        public Button exitButton;
        MoveForward moveforward;

        private void Start()
        {
            moveforward = GameObject.Find("player").GetComponent<MoveForward>();
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                endGameCanvas.SetActive(true);
                moveforward.topSpeed = 0;
            }

        }
        public void ExitGameButton()
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
