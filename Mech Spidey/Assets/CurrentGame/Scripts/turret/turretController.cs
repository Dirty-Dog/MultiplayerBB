using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretController : MonoBehaviour
{
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;
    float xRotation;
    float yRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {// get mouse input 
        float mouseX = Input.GetAxisRaw("Mouse X") + Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") + Time.deltaTime * sensY;
        yRotation += mouseX;
        xRotation -= mouseY;

        // rotate cam orentation
        Mathf.Clamp(yRotation, -45, 45);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
    }
    
}
