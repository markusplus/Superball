using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador : MonoBehaviour
{
    public GameObject bala, origen;
    private float time = 0.0f;
    public float interpolationPeriod;

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
        origen.transform.rotation = GameObject.Find("Tablero_container").transform.rotation;
        GameObject balaDisparada = (GameObject)Instantiate(bala, origen.transform.position, GameObject.Find("Tablero_container").transform.rotation, origen.transform);
    }
}
