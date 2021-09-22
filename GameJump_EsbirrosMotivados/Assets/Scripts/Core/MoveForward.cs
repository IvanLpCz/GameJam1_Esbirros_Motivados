using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class MoveForward : MonoBehaviour
    {
        [SerializeField] float topSpeed = 10;
        public Rigidbody boatRb;

        private void Start()
        {
            boatRb = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            boatRb.velocity = new Vector3(boatRb.velocity.x, boatRb.velocity.y, topSpeed);
        }
    }

}