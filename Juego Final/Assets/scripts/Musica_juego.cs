using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica_juego : MonoBehaviour
{
    AudioSource _audioSource;
    public static Musica_juego inst;
    void Awake()
    {
        if (Musica_juego.inst == null)
        {
            Musica_juego.inst = this;
            DontDestroyOnLoad(gameObject);
            _audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    public static void Pause()
    {
        inst._audioSource.Pause();
    }

    public static void UnPause()
    {
        inst._audioSource.UnPause();
    }
}
