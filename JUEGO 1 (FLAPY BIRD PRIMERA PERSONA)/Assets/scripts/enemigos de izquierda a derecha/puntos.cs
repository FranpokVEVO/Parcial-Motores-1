using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
public class puntos : MonoBehaviour
{
private int puntaje = 0;
    public Text t; // Arrastrar el Text en el inspector

    void OnEnable()
    {
        enemigo.OnEnemigoDestruido += SumarPunto; // Se suscribe al evento
    }

    void OnDisable()
    {
        enemigo.OnEnemigoDestruido -= SumarPunto; // Se desuscribe al cerrar
    }

    void SumarPunto()
    {
        puntaje++;
        t.text = "Puntos: " + puntaje.ToString();
    }
}
