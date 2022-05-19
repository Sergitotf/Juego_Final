using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio_escena : MonoBehaviour
{
   
    public void Onclick()
    {
        SceneManager.LoadScene(Random.Range(2,4));
    }

}
