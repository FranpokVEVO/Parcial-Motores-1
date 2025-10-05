using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoobstaculo : MonoBehaviour
{
    public float velocidad = 3f;
    public float maximoY = 5f;
    public float minimoY = 0f;
    private int direccion = 1;

    void Update()
    {
        transform.position += Vector3.up * velocidad * direccion * Time.deltaTime;
        if (transform.position.y >= maximoY)
        {
            direccion = -1;
        }
        else if (transform.position.y <= minimoY)
        {
            direccion = 1;
        }
    }
}