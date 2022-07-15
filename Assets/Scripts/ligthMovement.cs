using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ligthMovement:MonoBehaviour{
    float elapsed = 0f, rot = 0f;
    void Update(){
        elapsed += Time.deltaTime;
        if (elapsed >= 1f) {
            elapsed = elapsed % 1f;
            transform.position += new Vector3(0.0f, 0.0f, 5.0f);
            rot += 0.9f;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rot, -23.45f, 0.0f),  Time.deltaTime * 5.0f);
        }
    }
}
