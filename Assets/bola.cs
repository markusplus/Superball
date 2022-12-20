using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
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

    void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meta") && collision.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("Game Over");
            finPartida = true;
        }
    }
}
