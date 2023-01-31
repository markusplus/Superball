using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador : MonoBehaviour
{
    public GameObject bala, origen;
    private float time = 0.0f;
    private Rigidbody rb;
    public float interpolationPeriod;
    public float velX;
    public float velY;
    public float velZ;

    public static GameObject balaDisparada;

    // Start is called before the first frame update
    void Start()
    {
        Fire();
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            Fire();
            time = 0.0f;
        }
    }

    void Fire()
    {
        balaDisparada = (GameObject)Instantiate(bala, origen.transform);
        rb = balaDisparada.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(velX, velY, velZ);
        //rb.centerOfMass = GameObject.FindWithTag("Trayectoria").GetComponent<Rigidbody>().centerOfMass;
    }
}
