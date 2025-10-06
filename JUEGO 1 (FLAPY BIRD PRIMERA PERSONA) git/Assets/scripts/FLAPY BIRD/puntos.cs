using UnityEngine;
using TMPro;

public class SumarPuntos : MonoBehaviour
{
    public int puntos = 1;
    private TextMeshProUGUI textoPuntaje;
    private static long puntajeTotal = 0;

    void Start()
    {
        textoPuntaje = GameObject.FindGameObjectWithTag("Puntaje").GetComponent<TextMeshProUGUI>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puntajeTotal += puntos;
            textoPuntaje.text = "Puntos: " + puntajeTotal;
        }
    }
}
