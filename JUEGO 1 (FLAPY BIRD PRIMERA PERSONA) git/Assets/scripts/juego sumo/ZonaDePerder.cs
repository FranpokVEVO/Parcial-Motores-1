using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectorCaidas : MonoBehaviour
{
    public int enemigosNecesarios = 3;   // Enemigos que deben caer para ganar
    public int enemigosNecesarios = 3;   
    private int enemigosCaidos = 0;
    public float tiempoAntesDeFinalizar = 2f; // Retraso antes de reiniciar
    public float tiempoAntesDeFinalizar = 2f; 

    void OnTriggerEnter(Collider other)
    {
        // Si se cae un enemigo
       
        if (other.CompareTag("enemigo"))
        {
            enemigosCaidos++;
            Debug.Log("Enemigo caído: " + enemigosCaidos);

            Destroy(other.gameObject); // elimina al enemigo
            Destroy(other.gameObject); 

            // Si ya cayeron los necesarios → gana
           
            if (enemigosCaidos >= enemigosNecesarios)
            {
                Debug.Log("GANASTE");
                Invoke("ReiniciarEscena", tiempoAntesDeFinalizar);
            }
        }

        // Si se cae el jugador → pierde
       
        if (other.CompareTag("Jugador"))
        {
            Debug.Log("PERDISTE");
            Invoke("ReiniciarEscena", tiempoAntesDeFinalizar);
        }
    }

    void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
