using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSwitch : MonoBehaviour
{
    public bool isOn = true;
    public GameObject dark;

    void Update()
    {
        if (isOn)
        {
            dark.SetActive(true);
        }
        else
        {
            dark.SetActive(false);
        }
    }
    public void changeDark()
    {
        isOn = !isOn;
    }
}
