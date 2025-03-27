using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FlashButton : MonoBehaviour
{
    public bool isOn = false;
    public GameObject onImage;
    public GameObject offImage;
    public UnityEvent onClick;
    public LampController lampController;
    public LampFlasher lampFlasher;

    void Start()
    {
        TurnOff();
    }

    void OnMouseDown()
    {
        if (lampController.isOn == true && !isOn)
        {
            TurnOn();
            Debug.Log("Start Flashing 5s");
            onClick.Invoke();
        }   
    }

    public void TurnOn()
    {
        isOn = true;
        onImage.SetActive(true);
        offImage.SetActive(false);
    }
    public void TurnOff()
    {
        isOn = false;
        onImage.SetActive(false);
        offImage.SetActive(true);
    }
}