using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador_Escena : MonoBehaviour
{
    private bool primeraVez = true;

    public GameObject menu_victoria;

    private void Update()
    {
        if(Jugador.fin == true && primeraVez == true) {
            primeraVez = false;
            Restart();
        }
        else {
            if(tocaPantalla()) { //tocaPantalla()
                menu_victoria.SetActive(true);
                //Debug.Log("Se abre menu");
                Time.timeScale = 0f;
            }
        }
    }

    public bool tocaPantalla()
    {
        bool result = false;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                result = true;
            }
        }
        return result;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void siguienteEscena() {
        int siguiente = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(siguiente);
        if(siguiente > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", siguiente);
        }
    }

    public static void empiezaJuego()
    {
        SceneManager.LoadScene(2);
    }

    public static void menuPrincipal()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}