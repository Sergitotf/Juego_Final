using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador_position_character : MonoBehaviour
{
    public int posicionesrellenar;
    public int nivel = 1;
    public GameObject[] posiciones;
    public GameObject prefabpersonajes;
    public static generador_position_character instance;
    public float TiempoTranscurrido;


    public void Start()
    {
        TiempoTranscurrido = click_Character.instance.TiempoTranscurrido;
    }
    public void OnEnable()
    {

        
        TiempoTranscurrido += Time.deltaTime;

        nivel = nivel_actual.instance.nivel;
        
        //crea numero de posiciones como tantos hijos tenga el array

        posicionesrellenar = nivel * 5;

        for(int x=0; x< transform.childCount; x++)
        {
            posiciones[x] = transform.GetChild(x).gameObject;
        }
        int posicionaleatoria = Random.Range(0, posiciones.Length);
        GameObject wally = Instantiate(prefabpersonajes);
        Character_selector scriptWally = wally.GetComponent<Character_selector>();

        //deshabilita todos aquellos que no sean wally

        wally.transform.GetChild(scriptWally.indicepersonajeactivo).gameObject.SetActive(false);

        //habilita exclusivamente a wally

        wally.transform.GetChild(seleccion_personaje.instance.indicewally).gameObject.SetActive(true);
        click_Character clickar = wally.transform.GetChild(seleccion_personaje.instance.indicewally).gameObject.GetComponent<click_Character>();
        clickar.isWally = true;

        //mantiene las posiciones originales de los personajes, de forma que se quedan en los empty

        wally.transform.parent = posiciones[posicionaleatoria].transform;
        wally.transform.position = posiciones[posicionaleatoria].transform.position;
        Debug.Log("indice de wally: " + seleccion_personaje.instance.indicewally + "indice personaje activo: " + scriptWally.indicepersonajeactivo);
        rellenar(nivel);
    }

   public void rellenar(int nivelactual)
    {
        
        posicionesrellenar = (nivel * 5) -1;

        for(int x=1; x <= posicionesrellenar; x++)
        {
            int posicionaleatoria = Random.Range(0, posiciones.Length);
            if (posiciones[posicionaleatoria].transform.childCount == 0)
            {
                GameObject personaje = Instantiate(prefabpersonajes);
                personaje.transform.parent = posiciones[posicionaleatoria].transform;
                personaje.transform.position = posiciones[posicionaleatoria].transform.position; 
            }
        }


       
        //escoger posicion aleatoria, comprobar si esta vacia y si lo esta mete un personaje. Si no esta vacia, pasa a la siguiente.
    }

   
}
