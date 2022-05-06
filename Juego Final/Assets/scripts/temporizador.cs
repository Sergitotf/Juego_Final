using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class temporizador : MonoBehaviour
{
    public TextMeshProUGUI tiempotext;
    public float tiempo = 0.0f;
    public GameObject escena;
    public bool escenaactiva = false;

    public void Update()
    {
        
        tiempo -= Time.deltaTime;
        tiempotext.text = "" + tiempo.ToString("f0");
        if (tiempo <= 0.0f)
        {
            tiempo = 0;
        }
        
    }
}
