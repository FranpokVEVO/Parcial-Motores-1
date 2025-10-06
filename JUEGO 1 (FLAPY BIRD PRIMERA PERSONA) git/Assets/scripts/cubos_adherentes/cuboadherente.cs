using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cuboadherente : MonoBehaviour
{
    Rigidbody cuborb;
    public string tagplaneta = "planeta";
    public float power = 100f;
    public float velocidad_rotacion = 90f;
    void Start()
    {
        cuborb = GetComponent<Rigidbody>();
        cuborb.velocity = Vector3.right * power;
    }
    private bool pegado = false;
    void Update()
    {
        transform.Rotate(0, 0, velocidad_rotacion * Time.deltaTime, Space.Self);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (!pegado && collision.gameObject.CompareTag(tagplaneta))
        {
            Rigidbody rb = collision.rigidbody;
            if (rb != null)
            {
                FixedJoint fj = gameObject.AddComponent<FixedJoint>();
                fj.connectedBody = rb;
                pegado = true;
            }
        }

        if (gameObject.CompareTag("cubo") && collision.gameObject.CompareTag("cubo"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           
        }
    }
}
