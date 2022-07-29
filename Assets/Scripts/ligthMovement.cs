using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ligthMovement:MonoBehaviour{
    // roll inicial de la luz
    float roll = 30.0f;

    void Update(){
        // evita que la luz se eleve mas de lo necesario
        if(transform.position.y < 1000.0f){
            // ajusta la intensidad de la luz dependiendo de la distancia
            this.gameObject.GetComponent<Light>().intensity = transform.position.y / 100.0f;
            // traslacion, la luz sube en el eje 'y'
            transform.position += new Vector3(0.0f, 0.4f, 0.0f);
        }
        // traslacion, la luz se desplaza en el eje 'z'
        transform.position += new Vector3(0.0f, 0.0f, 0.2f);
        // asigna nuevo valor de roll
        roll += 0.025f;
        // rotacion, realiza roll para emular movimiento del sol
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(roll, -23.45f, 0.0f),  Time.deltaTime * 5.0f);
        // llama funcion cuando es de noche para volver a comenzar la animacion
        if(transform.position.z > 500.0f){
            resetLight();
        }
    }

    void resetLight(){
        // reestablece a los valores iniciales del objeto de luz
        roll = 30.0f;
        this.gameObject.GetComponent<Light>().intensity = 0.0f;
        transform.position = new Vector3(0.0f, 0.0f, -500.0f);
        transform.rotation = Quaternion.Euler(30.0f, -23.45f, 0.0f);
    }
}
