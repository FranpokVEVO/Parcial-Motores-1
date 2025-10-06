using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movimientoobstaculos : MonoBehaviour
{
    public float velocidad = 5f;      
    public float limite = 3f;               
    private Vector3 posInicial;
    private int direccion = 1;      

    void Start()
    {
        posInicial = transform.position;  
       
    }

    void Update()
    {
      
        
        transform.Translate(Vector3.right * velocidad * direccion * Time.deltaTime);

       
       
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
