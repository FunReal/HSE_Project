using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnScript : MonoBehaviour
{
    private MeshRenderer MyMR;
    // Start is called before the first frame update
    void Start()
    {
        MyMR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) {
            MyMR.enabled = !MyMR.enabled;
        }
    }
}
