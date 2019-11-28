using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, Input.GetAxis("Vertical")*moveSpeed);
    //    if(Input.GetButtonDown("Jump"))
    //    {
    //        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    //    }
    //}
    void Update()
    {
        //float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        //float moveZ = Input.GetAxis("Vertical") * moveSpeed;
        float moveY = rb.velocity.y;
        
        if (Input.GetButtonDown("Jump"))
        {
            moveY = jumpForce;
        }
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveY, Input.GetAxis("Vertical") * moveSpeed);
    }
}
