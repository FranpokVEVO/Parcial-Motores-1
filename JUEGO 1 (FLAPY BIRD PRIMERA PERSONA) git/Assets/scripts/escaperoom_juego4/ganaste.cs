using UnityEngine;
using UnityEngine.SceneManagement;

public class GanasteManager : MonoBehaviour
{
    public float tiempoAntesDeReiniciar = 2f; // tiempo antes de reiniciar la escena
    private bool juegoTerminado = false;

    void OnTriggerEnter(Collider other)
    {
        // Detecta al jugador
        if (!juegoTerminado && other.CompareTag("Jugador"))
        {
            juegoTerminado = true;
            Debug.Log("GANASTE"); // Muestra en la consola
            Invoke("ReiniciarEscena", tiempoAntesDeReiniciar);
        }
    }

    void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}