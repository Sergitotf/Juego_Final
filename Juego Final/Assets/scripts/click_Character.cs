using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click_Character : MonoBehaviour
{
    public bool isWally = false;
    bool Play;
    public AudioSource AudioClick;
    public AudioClip Fallo;
    public AudioClip Acierto;
    private int contaforfallos;

    private void OnMouseDown()
    {
       if(isWally)
        {
           
            //aumenta un nivel cuando detecta el click en wally y reproduce sonido
            nivel_actual.instance.nivel++;
            AudioClick = gameObject.GetComponent<AudioSource>();
            AudioClick.PlayOneShot(Acierto);
            Scene EscenaActual = SceneManager.GetActiveScene();
            SceneManager.LoadScene(EscenaActual.name);
        }

       if(!isWally)
        {
            // si hay mas de dos fallos, reinicia el juego a la pantalla principal
            AudioClick = gameObject.GetComponent<AudioSource>();
            AudioClick.PlayOneShot(Fallo);
            
            contaforfallos++;
            if (contaforfallos > 2)
            {
                SceneManager.LoadScene("Pantalla_principal");
            }
        }
    }
    
}
