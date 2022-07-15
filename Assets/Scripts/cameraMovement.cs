using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement:MonoBehaviour{
    void Update(){
        if(Input.GetButton("Jump")){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(Input.GetAxis("Vertical") * -30.0f + 10.689f, Input.GetAxis("Horizontal") * 60.0f - 90.149f, -0.045f),  Time.deltaTime * 5.0f);
        }
    }
}
