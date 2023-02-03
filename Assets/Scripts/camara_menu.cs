using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_menu : MonoBehaviour
{
    private bool sigue = true;
    private float time = 0.0f;
    public float interpolationPeriod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var posicion = gameObject.transform.position;
        bool ir = true;
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            if(posicion.x < 6.0f && sigue) {
                gameObject.transform.position = new Vector3(posicion.x+0.1f, posicion.y, +posicion.z+0.055f);
                time = 0.0f;
            }
            else if(posicion.x >= -12.0f){
                sigue = false;
                gameObject.transform.position = new Vector3(posicion.x-0.1f, posicion.y, +posicion.z-0.055f);
                time = 0.0f;
                if(posicion.x == -12.0f)
                    sigue = true;
            }
        }
    }
}
