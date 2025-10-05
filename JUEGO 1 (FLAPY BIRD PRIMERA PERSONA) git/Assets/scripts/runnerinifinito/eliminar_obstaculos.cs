using UnityEngine;
using UnityEngine.SceneManagement;

public class eliminar_obstaculos : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

    }
}

