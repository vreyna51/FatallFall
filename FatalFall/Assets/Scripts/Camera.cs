using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float rotateSpeed;
    public Transform pivot;

    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;

        //Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {

        //Get x position of mouse and rotate target
        float horizontal = Input.GetAxis("Mouse X")*rotateSpeed;
        target.Rotate(0, horizontal, 0);

        //Get y position of mouse and rotate pivot
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-vertical, 0, 0);

        //Limit up/down camera rotation
        if(pivot.rotation.eulerAngles.x > 45f && pivot.rotation.eulerAngles.x < 180f)
        {
            pivot.rotation = Quaternion.Euler(45f, 0f, 0f);
        }

        if (pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 315f)
        {
            pivot.rotation = Quaternion.Euler(315f, 0f, 0f);
        }

        //show the camera based on current rotation of target & original offset
            float desiredAngle = target.eulerAngles.y;
        float desiredXAngle = pivot.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredAngle, 0);
        transform.position = target.position - (rotation * offset);

        //transform.position = target.position - offset;

        if(transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y-0.5f, transform.position.z);
        }

        transform.LookAt(target);
    }
}
