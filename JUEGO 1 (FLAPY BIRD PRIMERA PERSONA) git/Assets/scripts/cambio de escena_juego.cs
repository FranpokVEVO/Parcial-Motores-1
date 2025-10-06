
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiodeescena_juego : MonoBehaviour
{
   
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("juego 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("juego 2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("juego 3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("juego 4");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("juego 5");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("juego 6");
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SceneManager.LoadScene("juego 7");
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
    }
}
}
