using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        [Range (0, 10)]
        [SerializeField] float turnSpeed = 5f;
        [Range(0, 1)]
        [SerializeField] float rotateSpeed = 1f;
        MoveForward moveforward;

        private void Start()
        {
            moveforward = GetComponent<MoveForward>();
        }

        private void Update()
        {
            //if (Input.GetKeyDown(KeyCode.D))
            //{
            //    moveforward.boatRb.velocity = new Vector3(turnSpeed, moveforward.boatRb.velocity.y, moveforward.boatRb.velocity.z);                
            //}
            //if (Input.GetKeyDown(KeyCode.A))
            //{
            //    moveforward.boatRb.velocity = new Vector3(-turnSpeed, moveforward.boatRb.velocity.y, moveforward.boatRb.velocity.z);
            //}
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        }
    }
}
