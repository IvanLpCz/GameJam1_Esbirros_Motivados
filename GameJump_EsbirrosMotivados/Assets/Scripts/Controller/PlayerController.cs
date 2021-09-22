using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        [Range (0, 10)]
        [SerializeField] float turnSpeed = 5;
        MoveForward moveforward;
        private bool goingRight, goingLeft = false;

        private void Start()
        {
            moveforward = GetComponent<MoveForward>();
        }
        private void Update()
        {
            goingRight |= Input.GetKeyDown(KeyCode.D);
            goingLeft |= Input.GetKeyDown(KeyCode.A);
        }
        private void FixedUpdate()
        {
            if(Input.GetKeyDown(KeyCode.D))
            {
                moveforward.boatRb.velocity = new Vector3(turnSpeed, moveforward.boatRb.velocity.y, moveforward.boatRb.velocity.z);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                moveforward.boatRb.velocity = new Vector3(-turnSpeed, moveforward.boatRb.velocity.y, moveforward.boatRb.velocity.z);
            }
        }
    }
}
