using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccion_personaje : MonoBehaviour
{
    public static seleccion_personaje instance;
    
    void Start()
    {
        if(seleccion_personaje.instance == null)
        {
            instance = this;
            if (transform.childCount > 0f)
            {

                gameObject.transform.GetChild(Random.Range(0,20)).gameObject.SetActive(true);
                

            }
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            gameObject.SetActive(false);
        }
        
    }

    
    
}
