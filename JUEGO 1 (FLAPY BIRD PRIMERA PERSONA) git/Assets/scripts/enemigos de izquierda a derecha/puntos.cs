using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos : MonoBehaviour
{
public static int puntajeTotal = 0;   // Puntaje global
    public TextMesh textoPuntaje;          // Asignar desde inspector
    public int puntosPorEnemigo = 1;      // Puntos que da cada enemigo

    private void OnEnable()
    {
        enemigo.OnEnemigoDestruido += SumarPuntos;
    }

    private void OnDisable()
    {
        enemigo.OnEnemigoDestruido -= SumarPuntos;
    }

    private void SumarPuntos()
    {
        puntajeTotal += puntosPorEnemigo;

        if (textoPuntaje != null)
            textoPuntaje.text = "Puntaje: " + puntajeTotal;

        Debug.Log("Puntaje: " + puntajeTotal);
    }
}
