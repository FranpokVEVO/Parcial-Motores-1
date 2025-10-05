using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaPorIndice : MonoBehaviour
{
    void Update()
    {
        // Detecta teclas del 1 al 9
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + (i - 1))) // Alpha1 = tecla 1
            {
                if (i < SceneManager.sceneCountInBuildSettings)
                {
                    SceneManager.LoadScene(i); // Carga la escena según su índice en Build Settings
                    Debug.Log("Cargando escena con índice: " + i);
                }
                else
                {
                    Debug.LogWarning("No hay ninguna escena en el Build Settings con índice " + i);
                }
            }
        }
    }
}