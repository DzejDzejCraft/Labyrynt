using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] float mouseSensevitity = 5;
    Transform playerTransform;
    float xRot = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerTransform = transform.parent;
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")* Time.deltaTime* mouseSensevitity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime* mouseSensevitity;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -60, 90);
        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        transform.Rotate(0, mouseY, 0);
        playerTransform.Rotate(0, mouseX, 0);
    }
}
