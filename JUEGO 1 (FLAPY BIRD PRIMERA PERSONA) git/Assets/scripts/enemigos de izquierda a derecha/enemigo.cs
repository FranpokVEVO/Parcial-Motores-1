using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigo : MonoBehaviour
{
    public float velocidad = 5f;   
    public int direccion = -1;    
    

    public delegate void EnemigoDestruidoAction();
    public static event EnemigoDestruidoAction OnEnemigoDestruido;

    void Update()
    {
        transform.Translate(Vector3.right * direccion * velocidad * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;

       
        if (tag == "bala")
        {
            OnEnemigoDestruido?.Invoke(); 
            Destroy(gameObject);
        }
        else if (tag == "Jugador")
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
