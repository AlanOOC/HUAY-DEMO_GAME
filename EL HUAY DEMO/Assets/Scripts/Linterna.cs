using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Linterna : MonoBehaviour
{
    public Light LuzLinterna;

    [Header("Energia")]
    public float EnergiaActual = 100; // Moví las variables de energía fuera del método Start()
    public float EnergiaMaxima = 100;
    public float VelocidadConsumo = 2f;
    public float VelocidadRecarga = 1f;


    [Header("Interfaz")]
    public Image BarraBateria;


    void Start()
    {
    
    }

    void Update()
    {
        //Aqui se enciende y apaga la linterna
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (LuzLinterna.enabled == true)
            {
                LuzLinterna.enabled = false;
            }
            else if (LuzLinterna.enabled == false && EnergiaActual > 10)
            {
                LuzLinterna.enabled = true;
            }
        }

        
        if (LuzLinterna.enabled == true)
        {
            EnergiaActual -= VelocidadConsumo * Time.deltaTime;

            if (EnergiaActual <= 0)
            {
                EnergiaActual = 0;
                LuzLinterna.enabled = false;
            }
        }

        else if (LuzLinterna.enabled == false)
        {
            EnergiaActual += VelocidadRecarga * Time.deltaTime;

            if (EnergiaActual >= EnergiaMaxima)
            {
                EnergiaActual = EnergiaMaxima;
            }
        }

        BarraBateria.fillAmount = EnergiaActual / EnergiaMaxima;



    }

}