using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(gameObject.transform.position.y < player.transform.position.y-15f)
        {
            Destroy(gameObject);
        }
    }
}
