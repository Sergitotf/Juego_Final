using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_movement : MonoBehaviour
{
    public GameObject Coche1;
    public GameObject Coche2;
    public GameObject Coche3;
    public GameObject Coche4;
    public GameObject Coche5;
    public GameObject Coche6;
    public GameObject Coche7;
    void Start()
    {
        LeanTween.moveX(Coche1, 3, 0);
        LeanTween.moveX(Coche2, 3, 0);
        LeanTween.moveX(Coche3, -3, 0);
        LeanTween.moveY(Coche4, 0, 3);
        LeanTween.moveY(Coche5, 0, -3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
