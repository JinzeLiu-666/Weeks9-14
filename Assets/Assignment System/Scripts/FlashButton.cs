using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FlashButton : MonoBehaviour
{
    public ToggleButton toggleButton;
    public bool isOn = false;
    public Sprite trunon;
    public Sprite trunoff;
    public Image buttonImage;

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

    public void changeImage()
    {
        if (Input.GetMouseButtonUp(0))
        {
            isOn = !isOn;
        }
    }
}