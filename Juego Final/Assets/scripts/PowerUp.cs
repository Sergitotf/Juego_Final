using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject powerup;
    public float Tiempo=0.0f;
    public int TiempoInicio;
    public int cantidadpersonajes;



    private void Start()
    {
        //if( TiempoInicio = Random.Range(20f, 150f))
        //{

        //}
        cantidadpersonajes = generador_position_character.instance.posicionesrellenar;
    }

    void Update()
    {
        Tiempo += Time.deltaTime;
        
        if(Tiempo <= 5)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void Onclick()
    {
        cantidadpersonajes = 1 / 2;
        gameObject.SetActive(false);
    }
}
