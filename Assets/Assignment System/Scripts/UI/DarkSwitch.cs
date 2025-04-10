using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSwitch : MonoBehaviour
{
    public bool isOn;
    public GameObject dark;
    void Start()
    {
        isOn = true;
    }

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

    // Change Bool by UnityEvent
    public void changeDark()
    {
        isOn = !isOn;
    }
}
