using UnityEngine;
using TMPro;  

public class puntos_aro : MonoBehaviour
{
    public static int puntajeTotal = 0;      
    public TextMeshProUGUI textoPuntaje;      
    public int puntosPorAro = 1;             

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
           
            puntajeTotal += puntosPorAro;

           
            if (textoPuntaje != null)
                textoPuntaje.text = "Puntaje: " + puntajeTotal;

            Debug.Log("Puntaje: " + puntajeTotal);

            
        }
    }
}
