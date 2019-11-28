using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject + "\n");
        Debug.Log("Success\n");
        Debug.Log(collision.gameObject);
    }
}
