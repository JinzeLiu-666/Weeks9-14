using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LampBreaker : MonoBehaviour
{
    public LampController lampController;
    public LampFlasher lampFlasher;

    public GameObject lightOverlay;
    public GameObject[] buttonsToDisable;

    private bool isBroken = false;

    public void DestroyLamp()
    {
        if (isBroken == false)
        {
            isBroken = true;

            StopAllCoroutines();
            lightOverlay.SetActive(false);
            lampController.TurnOff();

            for (int i = 0; i < buttonsToDisable.Length; i++)
            {
                buttonsToDisable[i].SetActive(false);
            }
        }
    }
}