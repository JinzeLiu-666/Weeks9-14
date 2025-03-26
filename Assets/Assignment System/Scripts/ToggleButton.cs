using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;

public class LampController : MonoBehaviour
{
    public GameObject lightOverlay;

    public GameObject onImage;
    public GameObject offImage;
    public bool isOn;


    void Start()
    {
        TurnOff();
    }

    void OnMouseDown()
    {
        if (isOn)
        {
            TurnOff();
        }
        else
        {
            TurnOn();
        }
    }
    public void TurnOn()
    {
        isOn = true;
        lightOverlay.SetActive(true);
        onImage.SetActive(true);
        offImage.SetActive(false);
    }

    public void TurnOff()
    {
        isOn = false;
        lightOverlay.SetActive(false);
        onImage.SetActive(false);
        offImage.SetActive(true);
    }
}