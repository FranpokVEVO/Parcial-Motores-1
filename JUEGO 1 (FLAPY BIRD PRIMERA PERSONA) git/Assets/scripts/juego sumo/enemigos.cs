using UnityEngine;

public class enemigos : MonoBehaviour
{
    public float velocidad = 5f;      
    private Transform jugador;       

    void Start()
    { 
        GameObject objJugador = GameObject.FindGameObjectWithTag("Jugador");

        if (objJugador != null)
        {
            jugador = objJugador.transform;
        }
    }

    void Update()
    {
        if (jugador != null)
        {
          
            Vector3 direccion = (jugador.position - transform.position).normalized;

           
            transform.position += direccion * velocidad * Time.deltaTime;

          
            transform.LookAt(jugador);
        }
    }
}
