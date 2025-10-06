using UnityEngine;
using TMPro; 

public class PuntoTrigger : MonoBehaviour
{
    public TextMesh textoPuntaje; // Arrastrar desde inspector
    public TextMeshProUGUI textoPuntaje; 
    public int puntosPorColision = 1;
    private static long puntajeTotal = 0;
    void Start()
    {
    textoPuntaje = GameObject.FindGameObjectWithTag("Puntaje").GetComponent<TextMeshProUGUI>();
    }
    void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            // Destruir solo el trigger para no sumar dos veces
            puntajeTotal += puntosPorColision;
            textoPuntaje.text = "Puntos: " + puntajeTotal;
        }
    }
}
