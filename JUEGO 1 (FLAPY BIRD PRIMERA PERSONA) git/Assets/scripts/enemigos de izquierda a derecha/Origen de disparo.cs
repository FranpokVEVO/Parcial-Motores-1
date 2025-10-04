using UnityEngine;

public class Origendedisparo : MonoBehaviour
{
    public Transform Disparo;
    public bool disparo;
    public GameObject bala;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()


    {
        disparo = Input.GetKeyDown(KeyCode.Mouse0);
        if (disparo)
        {
            instantiatebala();
        }

    }
    public void instantiatebala()
    {
        Instantiate(bala, Disparo.position, Disparo.rotation);
    }
}
