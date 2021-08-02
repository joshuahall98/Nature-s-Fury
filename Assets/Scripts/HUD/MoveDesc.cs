using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDesc : MonoBehaviour
{
    public GameObject moveDesc;

    public void Start()
    {
        moveDesc.SetActive(false);
    }

    public void OnMouseOver()
    {
        moveDesc.SetActive(true);
    }

    public void OnMouseExit()
    {
        moveDesc.SetActive(false);
    }
}
