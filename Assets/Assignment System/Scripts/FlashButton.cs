using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FlashButton : MonoBehaviour
{
    public bool isOn = false;
    public Sprite trunon;
    public Sprite trunoff;
    public Image buttonImage;
    public ToggleButton toggleButton;
    // public LampFlasher lampFlasher;

    void Start()
    {
        isOn = false;
    }

    void Update()
    {
        if (toggleButton.isOn && isOn)
        {
            buttonImage.sprite = trunon;
            Debug.Log("Start Flashing 5s");
        }
        else
        {
            buttonImage.sprite = trunoff;
        }
    }

    public void changeImage()
    {
        if (Input.GetMouseButtonUp(0))
        {
            isOn = !isOn;
        }
    }
}