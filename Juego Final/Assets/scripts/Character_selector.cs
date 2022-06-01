using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_selector : MonoBehaviour
{
    public int indicepersonajeactivo;
    private GameObject personajeactivo;
    
    void OnEnable()
    { // seleccion de un personaje random /= wally, nos servirá para los escondites.
        indicepersonajeactivo = Random.Range(0, 20);
        if(indicepersonajeactivo == seleccion_personaje.instance.indicewally)
        {
            if (indicepersonajeactivo < 20)
            {
                indicepersonajeactivo++;
            }
            else
            {
                indicepersonajeactivo--;
            }
        }
        personajeactivo = gameObject.transform.GetChild(indicepersonajeactivo).gameObject;
        personajeactivo.SetActive(true);
        Debug.Log("activo" + personajeactivo);
    }

    private void OnDisable()
    {
        personajeactivo.SetActive(false);
    }


    void Update()
    {
        
    }
}
