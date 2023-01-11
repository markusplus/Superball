using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private LineRenderer lr;
    private float time = 0.0f;
    public GameObject go;
    public float interpolationPeriod;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        Cast();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            go.GetComponent<Laser>().enabled = true;
            time = 0.0f;
        }
        else go.GetComponent<Laser>().enabled = false;
    }

    void Cast()
    {
        lr.SetPosition(0, transform.position);
        RaycastHit hit;
        
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.collider)
            {
                lr.SetPosition(1, hit.point);
            }
        }
        else lr.SetPosition(1, transform.forward*5000);
    }
}
