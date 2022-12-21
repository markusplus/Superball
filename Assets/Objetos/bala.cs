using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody bullet;
    private float time = 0.0f;
    public float interpolationPeriod;
    private GameObject origen;
    private bool primera = true;

    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (!primera)
        {
            if (time >= interpolationPeriod)
            {
                Fire();
                time = 0.0f;
            }
        }
        else 
        {
            Fire();
            time = 0.0f;

        }
    }
}
