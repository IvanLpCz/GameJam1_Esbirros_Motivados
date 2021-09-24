using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Controller;

namespace Core
{
    public class MoveForward : MonoBehaviour
    {
        [Range(0, 100)]
        [SerializeField] public float topSpeed = 10;
        public Rigidbody boatRb;
        HpSystem hpsystem;
        PlayerController playercontroller;

        private void Start()
        {
            boatRb = GetComponent<Rigidbody>();
            hpsystem = GetComponent<HpSystem>();
            playercontroller = GetComponent<PlayerController>();
        }
        private void Update()
        {
            boatRb.velocity = transform.forward * topSpeed;
            Debug.Log("Velocidad: " + topSpeed);

            if(hpsystem.numberOfPeople <= 0)
            {
                topSpeed = 0;
                playercontroller.rotateSpeed = 0;
            }
           //new Vector3(boatRb.velocity.x, boatRb.velocity.y, topSpeed);
        }
    }
}