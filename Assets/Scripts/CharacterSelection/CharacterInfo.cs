using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    public GameObject infoText;
    public GameObject infoBox;

    public void Start()
    {
        infoText.SetActive(false);
        infoBox.SetActive(false);
    }

    public void OnMouseOver()
    {
        infoText.SetActive(true);
        infoBox.SetActive(true);
    }

    public void OnMouseExit()
    {
        infoText.SetActive(false);
        infoBox.SetActive(false);
    }
}
