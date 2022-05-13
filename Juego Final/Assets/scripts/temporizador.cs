using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class temporizador : MonoBehaviour
{
    public TextMeshProUGUI tiempotext;
    public float tiempo = 0.0f;
    public GameObject escena1;
    public  bool escenaactiva = true;
    public GameObject escena2;
    public GameObject escenaprincipal;
    public bool desactivaprincipal = false;
    
    
    public void Awake()
    {
        if (escenaactiva == escena1)
        {
            //Destroy(gameObject);
            SceneManager.LoadScene("escena2");
        }
        else if (escenaactiva == escena2)
        {
            SceneManager.LoadScene("escena1");
        }
        desactivaprincipal = escenaprincipal; 
    }
    public void Update()
    {
        
        tiempo -= Time.deltaTime;
        tiempotext.text = "" + tiempo.ToString("f0");
        if (tiempo <= 0.0f)
        {
            tiempo = 0;
            Destroy(gameObject);
        }
        
    }

    public void cambioPantalla()
    {
       // GameObject(escenaactiva).setActive(true);
    }
}
