﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    //Rigidbody rb;

    public CharacterController controller;
    private Vector3 moveDirection;
    public float gravityScale;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        controller.GetComponent<CharacterController>();
    }
    
    void Update()
    {
        //float moveY = rb.velocity.y;

        //if (Input.GetButtonDown("Jump"))
        //{
        //    moveY = jumpForce;
        //}
        //rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveY, Input.GetAxis("Vertical") * moveSpeed);

        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);
        float yStore = moveDirection.y;
        moveDirection = (transform.forward*Input.GetAxis("Vertical")) + (transform.right* Input.GetAxis("Horizontal"));
        moveDirection = moveDirection.normalized * moveSpeed;
        moveDirection.y = yStore;

        if (controller.isGrounded)
        {
            moveDirection.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }
        moveDirection.y += (Physics.gravity.y * gravityScale);
        controller.Move(moveDirection*Time.deltaTime);
    }
}
