using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LampBreaker : MonoBehaviour
{
    public ToggleButton ToggleButton;
    public LampFlasher lampFlasher;

    public GameObject can;

    private bool isBroken = false;

    public void DestroyLamp()
    {
        if (isBroken == false)
        {
            isBroken = true;

            StopAllCoroutines();
            can.SetActive(false);
        }
    }
}