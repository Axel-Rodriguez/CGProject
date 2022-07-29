using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement:MonoBehaviour{
    // inicializa multiplicador de movimiento
    float speedH = 2.0f, speedV = 2.0f;
    // rotacion inicial
    float yaw = -90.0f, pitch = 10.0f;

    void Update(){
        // cuando se haga click
        if(Input.GetButton("Fire1")){
            // calcula el nuevo yaw y pitch con el input del mouse
            yaw += speedH * -Input.GetAxis("Mouse X");
            pitch -= speedV * -Input.GetAxis("Mouse Y");
            // rotacion, asigna nuevo yaw y pitch
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
        // al presionar w, s o up, down
        if(Input.GetButton("Vertical")){
            // traslacion, suma input a la posicion actual en eje x
            transform.position += new Vector3(Input.GetAxis("Vertical") * -0.5f, 0.0f, 0.0f);
        }
        // al presionar a, d o left, right
        else if(Input.GetButton("Horizontal")){
            // traslacion, suma input a la posicion actual en eje z
            transform.position += new Vector3(0.0f, 0.0f, Input.GetAxis("Horizontal") * 0.5f);
        }
    }
}
