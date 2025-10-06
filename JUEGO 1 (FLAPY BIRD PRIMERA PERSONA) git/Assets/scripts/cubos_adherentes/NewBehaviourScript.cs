using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion_planeta : MonoBehaviour
{
    public float velocidad_rotacion = 90f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
        rb.angularVelocity = new Vector3(0, 0, velocidad_rotacion * Mathf.Deg2Rad);
    }

}
