using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiempo : MonoBehaviour
{
public float timer = 0f;
    public TextMesh texto_timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (texto_timer != null)
            texto_timer.text = timer.ToString("F0"); 
    }
}
