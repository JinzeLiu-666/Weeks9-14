using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LampBreaker : MonoBehaviour
{
    public GameObject can;
    public GameObject lamp;
    public bool broken = true;

    // Called by UnityEvent
    public void DestroyLamp()
    {
        broken = false;
        // Close all UI button
        can.SetActive(false);
        // Destroy the break lamp
        Destroy(lamp, 3f);
    }
}