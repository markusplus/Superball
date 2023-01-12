using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meta : MonoBehaviour
{
    public bool finPartida;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I'm the trigger, someone has enter");

        if (other.tag == "Jugador")
        {
            finPartida = true;
        }

    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit Event");

        if (other.tag == "Jugador")
        {

        }


    }
}
