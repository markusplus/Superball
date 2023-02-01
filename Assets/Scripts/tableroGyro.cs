using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableroGyro : MonoBehaviour
{
    public static Transform target;
    public float velocidad;
    public float anguloMax;

    private float tiltAroundZ;
    private float tiltAroundX;
    private Gyroscope gyro;
    private bool gyroActive;

    public void Start() 
    {
        EnableGyro();
    }
    
    public void EnableGyro()
    {
        if(gyroActive) {
            Debug.Log("Giroscopio activo");
            return;
        }

        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
        gyroActive = gyro.enabled;
    }

    public void Update()
    {
        if(gyroActive)
        {
            // Smoothly tilts a transform towards a target rotation.
            tiltAroundZ = gyro.attitude.y * anguloMax;
            tiltAroundX = gyro.attitude.x * anguloMax;

            // Rotate the cube by converting the angles into a quaternion.
            Quaternion target = Quaternion.Euler(-tiltAroundZ, 0, tiltAroundX);

            // Dampen towards the target rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * velocidad);
            Debug.Log(transform.rotation);
        }
    }
}
