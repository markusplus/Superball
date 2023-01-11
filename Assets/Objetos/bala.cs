using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour
{
    public float bulletSpeed;
    private Rigidbody rb;
    public static bool fin = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(bulletSpeed, 0, 0);
        fin = false;
    }

    void Update()
    {
        //rb.transform.position = new Vector3(rb.transform.position.x, GameObject.Find("DestinoDisparo").transform.position.y - GameObject.Find("OrigenDisparo").transform.position.y, rb.transform.position.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Pared")
        {
            Destroy(gameObject);
            //Debug.Log("Me tengo que destruir");
        }
        else if(collision.collider.tag == "Jugador")
        {
            Debug.Log("Se acaba la partida");
            fin = true;
        }

    }
}
