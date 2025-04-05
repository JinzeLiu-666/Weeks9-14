using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FlashButton : MonoBehaviour
{
    public ToggleButton toggleButton;
    
    public bool isOn = false;
    
    public Image buttonImage;
    public Sprite trunon;
    public Sprite trunoff;

    void Start()
    {
        isOn = false;
    }

    void Update()
    {
        if (isOn)
        {
            buttonImage.sprite = trunon;
        }
        else
        {
            buttonImage.sprite = trunoff;
        }
    }

    // Change Bool by UnityEvent

    public void changeImage()
    {
        isOn = !isOn;
    }
}