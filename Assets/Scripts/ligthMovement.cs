using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ligthMovement:MonoBehaviour{
    /* float elapsed = 0f, rot = 45f;
    void FixedUpdate(){
        elapsed += Time.deltaTime;
        if (elapsed >= 1f) {
            elapsed = elapsed % 1f;
            transform.position += new Vector3(0.0f, 0.0f, 10.0f);
            rot += 1f;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rot, -23.45f, 0.0f),  Time.deltaTime * 5.0f);
        }
    } */
    float rot = 30.0f, intensity = 5.0f;
    void Update(){
        intensity += 0.001f;
        this.gameObject.GetComponent<Light>().intensity = intensity;
        if(transform.position.y < 1300.0f){
            transform.position += new Vector3(0.0f, 0.4f, 0.0f);
        }
        transform.position += new Vector3(0.0f, 0.0f, 0.2f);
        rot += 0.025f;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rot, -23.45f, 0.0f),  Time.deltaTime * 5.0f);
        if(transform.position.z > 500.0f){
            resetLight();
        }
    }

    void resetLight(){
        rot = 30.0f;
        intensity = 5.0f;
        transform.position = new Vector3(0.0f, 0.0f, -500.0f);
        transform.rotation = Quaternion.Euler(30.0f, -23.45f, 0.0f);
    }
}
