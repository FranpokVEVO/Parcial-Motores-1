using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class obstaculoquerota : MonoBehaviour
{
    public Vector3 velocidadRotacion = new Vector3(0, 100f, 0); // grados por segundo
    public Vector3 velocidadRotacion = new Vector3(0, 100f, 0); 

    void Update()
    {
        // Rota el objeto cada frame
       
        transform.Rotate(velocidadRotacion * Time.deltaTime);
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
