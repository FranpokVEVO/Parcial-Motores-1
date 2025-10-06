using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public Transform punto_de_disparo;
    public GameObject preafabcubo;

    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            instantiateCubo();
        }
    }
    public void instantiateCubo()
    {
        GameObject cubo = Instantiate(preafabcubo, punto_de_disparo.position, punto_de_disparo.rotation);
        
    }

}
