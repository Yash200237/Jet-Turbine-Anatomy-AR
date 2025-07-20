using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    public GameObject part;
    private bool isDisable=false;
    public void Toggle()
    {
        if (isDisable)
        {
            part.SetActive(true);
            isDisable = false;
        }
        else
        {
            part.SetActive(false);
            isDisable = true;
        }
    }
}
