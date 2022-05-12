using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_music : MonoBehaviour
{
    [SerializeField] private string nombreEscenaSiguiente;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("nombreEscenaSiguiente");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Musica_juego.Pause();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Musica_juego.UnPause();
        }
    }
}
