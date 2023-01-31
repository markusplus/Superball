using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Pared")
        {
            Destroy(gameObject);
            //Debug.Log("Me tengo que destruir");
        }
    }
}
