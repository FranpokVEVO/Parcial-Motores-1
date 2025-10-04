using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class tiempo : MonoBehaviour
{
    public float timer = 0;
    public Text texto_timer;
    void Update()
    {
        timer += Time.deltaTime;
        texto_timer.text = "" + timer.ToString("f0");
    }
}
