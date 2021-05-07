using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBase_Simulation : MonoBehaviour
{
    //Pantallas
    public GameObject ThisScreen;
    public GameObject NextScreen;

    //Datos del Usuario
    public Text UserName;
    public Text Password;

    public bool Registered;

    public Text Can_Not_Register;



    public void Update()
    {
        Simulation();
    }

    public void Simulation()
    {
        if(UserName.text != "" && Password.text != "")
        {
            Registered = true;
        }
    }

    public void ScreenTransition()
    {
        if(Registered)
        {
            ThisScreen.SetActive(false);
            NextScreen.SetActive(true);
        }
        else
        {
            Can_Not_Register.text = "No se ha podido registrar (Datos Incompletos)";
        }      
    }
}
