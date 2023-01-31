using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public static bool fin = false;
    void Start()
    {
        fin = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemigo")
        {
            Debug.Log("Reinicia");
            fin = true;
        }

    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Enemigo")
            fin = true;
        else if(other.tag == "Meta")
            Debug.Log("Siguiente nivel");
            Controlador_Escena.siguienteEscena();
    }
}
