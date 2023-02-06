using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class seleccion_nivel : MonoBehaviour
{
    public Button[] lvlButtons;
    public GameObject menu;

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < lvlButtons.Length; i++) 
        {
            if (i + 2 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void cargaNivel1()
    {
        SceneManager.LoadScene(2);
    }

    public static void cargaNivel2()
    {
        SceneManager.LoadScene(3);
    }

    public static void cargaNivel3()
    {
        SceneManager.LoadScene(4);
    }

    public void cargaMenu_niveles()
    {
        menu.SetActive(true);
        GameObject.Find("menu_niveles").SetActive(false);
    }

    public void cargaMenu_ayuda()
    {
        menu.SetActive(true);
        GameObject.Find("menu_ayuda").SetActive(false);
    }
}
