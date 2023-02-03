using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class canvas : MonoBehaviour
{
    private float time; 
    private int minutos = 0;
    private int segundos = 0;

    public TMP_Text temporizador;

    void Start()
    {
        time = 0.0f;
    }

    void Update()
    {
        time += Time.deltaTime;
        if(segundos >= 10)
            temporizador.text = "0"+minutos.ToString() + ":" + segundos.ToString();
        else
            temporizador.text = "0"+minutos.ToString() + ":" + "0"+segundos.ToString();
        segundos = Mathf.RoundToInt(time);
        if(time >= 60) {
            minutos++;
            time = 0;
        }
    }

    public static void Resume() 
    {
        GameObject.Find("menu_pausa").SetActive(false);
        Time.timeScale = 1f;
    }
}
