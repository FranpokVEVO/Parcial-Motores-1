using UnityEngine;

public class PuntosTrigger : MonoBehaviour
{
    public int puntos = 1;
    public static int puntajeTotal = 0;
    public TextMesh textoPuntaje; // Arrastrar desde inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puntajeTotal += puntos;

            if (textoPuntaje != null)
                textoPuntaje.text = "Puntaje: " + puntajeTotal;

            Debug.Log("Jugador pasó y sumó puntos: " + puntajeTotal);

            // Destruir solo el trigger para no sumar dos veces
            Destroy(gameObject);
        }
    }
}
