using UnityEngine;
using TMPro; 

public class punto: MonoBehaviour
{

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
            
            puntajeTotal += puntosPorColision;
            textoPuntaje.text = "Puntos: " + puntajeTotal;
        }
    }
}
