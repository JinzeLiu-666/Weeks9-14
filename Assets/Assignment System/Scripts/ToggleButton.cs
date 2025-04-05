using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    public GameObject lightOverlay;
    public bool isOn;
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
            lightOverlay.SetActive(true);
        }
        else
        {
            buttonImage.sprite = trunoff;
            lightOverlay.SetActive(false);
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