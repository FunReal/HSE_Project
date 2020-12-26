using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text UIText;
    public CubePhisics a;
    private float axyz = 0;
    void Start()
    {
        
    }
    void Update()
    {
        axyz = Mathf.Sqrt((a.acceleration.x * a.acceleration.x)
            + (a.acceleration.y) * (a.acceleration.y)
            + (a.acceleration.z) * (a.acceleration.z));
        UIText.text = "Acceleration : " + Mathf.Round(axyz)+" m/s";
    }
}
