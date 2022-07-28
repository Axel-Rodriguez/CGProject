using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement:MonoBehaviour{
    float speedH = 2.0f, speedV = 2.0f;
    float yaw = -90.0f, pitch = 10.0f;

    void Update(){
        /* if(Input.GetButton("Jump")){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(Input.GetAxis("Vertical") * -30.0f + 10.0f, Input.GetAxis("Horizontal") * 60.0f - 90.0f, 0.0f),  Time.deltaTime * 5.0f);
        } */
        if(Input.GetButton("Fire1")){
           /*  if(Input.GetButton("Vertical")){
                transform.Rotate(transform.rotation.x + Input.GetAxis("Vertical") * -0.5f, 0.0f, 0.0f);
            }
            else if(Input.GetButton("Horizontal")){
                transform.Rotate(0.0f, transform.rotation.y + 1.0f, 0.0f);
            } */
            yaw += speedH * -Input.GetAxis("Mouse X");
            pitch -= speedV * -Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
        if(Input.GetButton("Vertical")){
            transform.position += new Vector3(Input.GetAxis("Vertical") * -0.5f, 0.0f, 0.0f);
        }
        else if(Input.GetButton("Horizontal")){
            transform.position += new Vector3(0.0f, 0.0f, Input.GetAxis("Horizontal") * 0.5f);
        }
    }
}
