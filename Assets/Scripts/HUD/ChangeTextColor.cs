using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextColor : MonoBehaviour
{
    public void greenColor()
    {
        GetComponent<Text>().color = new Color(0f,0.50f,0.20f,1f);
    }

    public void redColor()
    {
        GetComponent<Text>().color = new Color(0.60f,0f,0f,1f);
    }
}
