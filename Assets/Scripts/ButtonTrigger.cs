using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject go;
    public Text txt;
    public GameObject bt;
    public void Click()
    {
        go.SetActive(!go.active);
        Debug.Log(bt.transform.localPosition.y);
        if (go.active)
        {
            bt.transform.localPosition = new Vector3(bt.transform.localPosition.x, bt.transform.localPosition.y-30, bt.transform.localPosition.z);
            txt.text = "скрыть";
        }
        else 
        {
            bt.transform.localPosition = new Vector3(bt.transform.localPosition.x, bt.transform.localPosition.y + 30, bt.transform.localPosition.z);
            txt.text = "показать"; 
        }
    }
}
