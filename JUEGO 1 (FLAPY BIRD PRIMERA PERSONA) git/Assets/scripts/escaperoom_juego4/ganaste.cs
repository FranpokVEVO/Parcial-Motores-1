using UnityEngine;
using UnityEngine.SceneManagement;

public class GanasteManager : MonoBehaviour
{
    public float tiempoAntesDeReiniciar = 2f; 
    private bool juegoTerminado = false;

    void OnTriggerEnter(Collider other)
    {
      
        
        if (!juegoTerminado && other.CompareTag("Jugador"))
        {
            juegoTerminado = true;
            Debug.Log("GANASTE"); 
            Invoke("ReiniciarEscena", tiempoAntesDeReiniciar);
        }
    }

    void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}