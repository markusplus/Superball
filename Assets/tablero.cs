using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablero : MonoBehaviour
{
    public Transform target;
    public float velocidad;
    public float anguloMax;
    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * anguloMax;
        float tiltAroundX = Input.GetAxis("Vertical") * anguloMax;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * velocidad);
    }
}
