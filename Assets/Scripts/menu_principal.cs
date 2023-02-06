using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_principal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu_niveles;
    public GameObject menu_ayuda;

    void Start()
    {
        
    }

    public static void Jugar()
    {
        Controlador_Escena.empiezaJuego();
    }

    public void Niveles()
    {
        menu_niveles.SetActive(true);
        GameObject.Find("menu_principal").SetActive(false);
    }

    public void Ayuda()
    {
        menu_ayuda.SetActive(true);
        GameObject.Find("menu_principal").SetActive(false);
    }
}
