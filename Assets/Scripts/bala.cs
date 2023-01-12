using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour
{
    public float bulletSpeed;
    public static Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(bulletSpeed, -5, 0);
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
