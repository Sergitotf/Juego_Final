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
    public GameObject posExterior;
    public GameObject posInterior;
    
    
    
    public void Update()
    {
        
        tiempo -= Time.deltaTime;
        tiempotext.text = "" + tiempo.ToString("f0");
        if (tiempo <= 0.0f)
        {
            tiempo = 0;
            if (SceneManager.GetActiveScene().name == "Exterior")
            {
                posExterior.SetActive(true);
            }
            if (SceneManager.GetActiveScene().name == "Interior")
            {
                posInterior.SetActive(true);
            }
            Destroy(gameObject);

        }
        
    }

    public void cambioPantalla()
    {
       // GameObject(escenaactiva).setActive(true);
    }
}
