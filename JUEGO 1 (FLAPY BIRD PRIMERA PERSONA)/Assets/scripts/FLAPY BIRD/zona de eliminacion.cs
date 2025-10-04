using Unity.VisualScripting;
using UnityEngine;

public class zonadeeliminacion : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
