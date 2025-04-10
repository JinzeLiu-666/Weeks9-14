using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    public LampBreaker lampBreaker;
    
    public bool isOn;
    
    public Image buttonImage;
    public Sprite trunon;
    public Sprite trunoff;

    public GameObject lightOn;
    public GameObject lightOff;

    void Start()
    {
        isOn = false;
    }

    void Update()
    {
        // Check if the lamp is broken and the button is pressed
        if (isOn && lampBreaker.broken)
        {
            buttonImage.sprite = trunon;
            lightOn.SetActive(true);
            lightOff.SetActive(false);
        }
        else
        {
            buttonImage.sprite = trunoff;
            lightOn.SetActive(false);
            lightOff.SetActive(true);
        }
    }

    public void changeImage() 
    {
        isOn = !isOn;
    }
}