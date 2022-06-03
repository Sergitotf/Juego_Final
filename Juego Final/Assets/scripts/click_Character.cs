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
    public GameObject pantallaPuntos;
    public float TiempoTranscurrido;
    public float PuntuacionNivel = 0;
    private int posicionesrellenar;
    public static click_Character instance;

    public int PuntuacionTotal;


    private void Start()
    {
        posicionesrellenar = generador_position_character.instance.posicionesrellenar;
    }
    private void OnMouseDown()
    {
        

        

        if (isWally)
        {
           
            //aumenta un nivel cuando detecta el click en wally y reproduce sonido

            nivel_actual.instance.nivel++;
            AudioClick = gameObject.GetComponent<AudioSource>();
            AudioClick.PlayOneShot(Acierto);

            pantallaPuntos.SetActive(true);

            Debug.Log("acierto");
            //Scene EscenaActual = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(EscenaActual.name);
        }

        if (!isWally)
        {
            // si hay mas de dos fallos, reinicia el juego a la pantalla principal
            AudioClick = gameObject.GetComponent<AudioSource>();
            AudioClick.PlayOneShot(Fallo);
            
            contaforfallos++;
            if (contaforfallos > 0)
            {
                
                //SceneManager.LoadScene("Pantalla_principal");
                TiempoTranscurrido = TiempoTranscurrido + 10f;

               
                PuntuacionNivel = generador_position_character.instance.posicionesrellenar * 100 / TiempoTranscurrido;
                Debug.Log("El tiempo aumenta 10s ");


            }
        }

    }

    public void reintentar()
    {

    }
    
}
