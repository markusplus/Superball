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
            //Debug.Log("Se acaba la partida");
            fin = true;
        }

    }
}
