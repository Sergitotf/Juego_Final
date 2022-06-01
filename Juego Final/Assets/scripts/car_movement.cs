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
        LeanTween.moveX(Coche1, 80, 35);//.setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(Coche2, 50, 40);//.setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(Coche3, -50, 15);
        LeanTween.moveZ(Coche4, 40, 15);
        LeanTween.moveZ(Coche5, -40, 15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
