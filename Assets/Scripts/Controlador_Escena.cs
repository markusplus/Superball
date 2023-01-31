using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador_Escena : MonoBehaviour
{
    private bool primeraVez = true;

    private void Update()
    {
        if(Jugador.fin == true && primeraVez == true) {
            primeraVez = false;
            Restart();
        }
        //Debug.Log(Mathf.Clamp01(loadingOperation.progress / 0.9f));
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void siguienteEscena() {
        int siguiente = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(siguiente);
    }
}