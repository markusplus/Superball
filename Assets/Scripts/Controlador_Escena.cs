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

        var fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }
        }
        if (fingerCount > 0)
        {
            Debug.Log("Se abre el menu");
        }
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