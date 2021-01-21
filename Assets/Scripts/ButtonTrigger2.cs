using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger2 : MonoBehaviour
{
    public Text txt;
    public GameObject bt;
    private bool isActive = false;
    public void Click2()
    {
        isActive = !isActive;
        if (isActive)
        {
            txt.text = "-";
            bt.transform.localPosition = new Vector3(bt.transform.localPosition.x-100, bt.transform.localPosition.y , bt.transform.localPosition.z);
        }
        else
        {
            txt.text = "+";
            bt.transform.localPosition = new Vector3(bt.transform.localPosition.x+100, bt.transform.localPosition.y, bt.transform.localPosition.z);
        }
    }
}
