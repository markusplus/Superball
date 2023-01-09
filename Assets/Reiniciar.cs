using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    private bool primeraVez = true;

    private void Update()
    {
        if(bala.fin == true && primeraVez == true) {
            primeraVez = false;
            Restart();
        }
        //Debug.Log(Mathf.Clamp01(loadingOperation.progress / 0.9f));
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}