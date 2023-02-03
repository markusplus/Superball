using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pared_rotatoria : MonoBehaviour
{

    private GameObject go;
    public float speed;

    void Start()
    {
        go = gameObject;
    }

    void Update()
    {
        go.transform.Rotate(Vector3.up, 10 * Time.deltaTime * speed);
    }
}
