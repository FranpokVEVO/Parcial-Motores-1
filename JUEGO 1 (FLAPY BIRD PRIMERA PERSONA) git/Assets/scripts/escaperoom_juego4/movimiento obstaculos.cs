using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movimientoobstaculos : MonoBehaviour
{
    public float velocidad = 5f;       // Velocidad de movimiento
    public float limite = 3f;          // Distancia máxima desde la posición inicial

    private Vector3 posInicial;
    private int direccion = 1;         // 1 = derecha, -1 = izquierda

    void Start()
    {
        posInicial = transform.position;  // Guardamos la posición inicial
    }

    void Update()
    {
        // Movemos la pared
        transform.Translate(Vector3.right * velocidad * direccion * Time.deltaTime);

        // Si se pasa del límite, invertimos dirección
        if (Mathf.Abs(transform.position.x - posInicial.x) >= limite)
        {
            direccion *= -1;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;

        if (tag == "Jugador")
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    
}
