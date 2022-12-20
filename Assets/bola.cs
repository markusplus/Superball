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

    void onTriggerEnter(Collider collider)
    {
        Debug.Log("Game Over");
        if (collider.gameObject.CompareTag("Meta"))
        {
            finPartida = true;
        }
    }
}
