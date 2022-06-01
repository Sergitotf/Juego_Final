using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccion_personaje : MonoBehaviour
{
    public static seleccion_personaje instance;
    public int indicewally;
    
    void Start()
    {
        indicewally = Random.Range(0, 20);
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
