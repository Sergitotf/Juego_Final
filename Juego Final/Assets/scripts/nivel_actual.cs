using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nivel_actual : MonoBehaviour
{
    public int nivel = 1;

    public static nivel_actual instance;
    public void Start()
    {
        if (nivel_actual.instance == null)
        {
            nivel_actual.instance = this;
        }
        else
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void OnAwake()
    {
        if(nivel_actual.instance == null)
        {
            nivel_actual.instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
