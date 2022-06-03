using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccion_personaje : MonoBehaviour
{
    public static seleccion_personaje instance;
    public int indicewally;
    
    void Start()
    {
        //activa a todos los personajes en la pantalla de wally

        indicewally = Random.Range(0, 21);
        if (seleccion_personaje.instance == null)
        {
            instance = this;
            if (transform.childCount > 0f)
            {

                gameObject.transform.GetChild(indicewally).gameObject.SetActive(true);
                

            }
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            gameObject.SetActive(false);
        }
        
    }

    
    
}
