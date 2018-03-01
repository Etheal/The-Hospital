using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hud : MonoBehaviour {

    bool mostrar = false;
    public GameObject fondoInventario;

    public void abrirInventario()
    {
        if (mostrar)
        {
            mostrar = false;
            fondoInventario.SetActive(false);
        }
        else
        {
            mostrar = true;
            fondoInventario.SetActive(true);
        }
    }

    public GameObject fondoOpciones;

    public void abrirOpcioneso()
    {
        if (mostrar)
        {
            
            mostrar = false;
            fondoOpciones.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            
            mostrar = true;
            fondoOpciones.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public GameObject fondoAgenda;

    public void AbrirAgenda()
    {
        if (mostrar)
        {

            mostrar = false;
            fondoAgenda.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {

            mostrar = true;
            fondoAgenda.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public GameObject exit;

    public void exitGame()
    {
        Application.Quit();
    }

    public GameObject back;

    
}
