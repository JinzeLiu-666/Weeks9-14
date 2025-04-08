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

    public Button thisButton;
    public Sound soundScript;
    private bool listenerAdded = false;

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

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (!listenerAdded)
            {
                // Add the listener to the button
                thisButton.onClick.AddListener(soundScript.Click);
                listenerAdded = true;
                Debug.Log("Sound listener added.");
            }
            else
            {
                // Remove the listener from the button
                thisButton.onClick.RemoveListener(soundScript.Click);
                listenerAdded = false;
                Debug.Log("Sound listener removed.");
            }
        }
    }

    public void changeImage()
    {
        isOn = !isOn;
    }
}