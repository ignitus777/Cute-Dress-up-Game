using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    public GameObject beach;
    public GameObject bedroom;
    public bool isBedroom = false;

    void Start()
    {
        
    }

    void Update()
    {

    }
    public void BackgroundChange()
    {
        if (isBedroom == false)
        {
            beach.SetActive(false);
            bedroom.SetActive(true);
            isBedroom = true;
        }
        else
        {
            beach.SetActive(true);
            bedroom.SetActive(false);
            isBedroom = false;
        }
    }
}
