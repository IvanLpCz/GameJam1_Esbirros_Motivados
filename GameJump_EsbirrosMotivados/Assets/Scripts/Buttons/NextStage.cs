using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class NextStage : MonoBehaviour
    {
        public Button next;
        private int sceneID;
        public void Start()
        {
            sceneID = SceneManager.GetActiveScene().buildIndex;
        }

        public void NextPhase()
        {
            sceneID++;
            SceneManager.LoadScene(sceneID);
        }
    }

}