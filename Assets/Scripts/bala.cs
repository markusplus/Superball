using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour
{
    public static Rigidbody rb;

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
