using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCamerav2 : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    public float minTurnAngle = -90f;
    public float maxTurnAngle = 90f;
    public GameObject player;
    private float rotX;
    
    void Update()
    {
        MouseAiming();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (Input.GetKeyDown("1"))
        {
            Cursor.lockState =CursorLockMode.None;
            Cursor.visible = true; 
        }
        
    }
    void MouseAiming()
    {
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += -Input.GetAxis("Mouse Y") * turnSpeed;
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        player.transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }
    
}