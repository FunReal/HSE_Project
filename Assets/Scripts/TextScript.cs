using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    private int presses = 0;
    public Text UIText;
    // public Vector3 ac;
    void Start()
    {
        
    }
    void Update()
    {

        UIText.text = "Acselleration.x : " + presses;
        presses++;
    }
}
