using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    [Range(0.01f, 1.0f)]
    public float smoothSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.Find("Sphere").transform;
        //offset = tranform.position - target.position;
    }
    void LateUpdate()
    {
        //Vector3 newPos = target.position + offset;
        transform.position = Vector3.Slerp(transform.position, target.position, smoothSpeed);
    }
}
