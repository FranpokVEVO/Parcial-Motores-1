using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectorCaidas : MonoBehaviour
{
    public int enemigosNecesarios = 3;   
    private int enemigosCaidos = 0;
    public float tiempoAntesDeFinalizar = 2f; 

    void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("enemigo"))
        {
            enemigosCaidos++;
            Debug.Log("Enemigo caído: " + enemigosCaidos);

            Destroy(other.gameObject); 

           
            if (enemigosCaidos >= enemigosNecesarios)
            {
                Debug.Log("GANASTE");
                Invoke("ReiniciarEscena", tiempoAntesDeFinalizar);
            }
        }

       
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
