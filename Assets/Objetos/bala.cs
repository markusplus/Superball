using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour
{
    public float bulletSpeed;
    private Rigidbody rb;

    /*void Fire()
    {
        bulletClone = Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
    }*/

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(bulletSpeed, 0, 0);
    }

    void Update()
    {

    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Pared")
    //    { 

    //    }
    //}
}
