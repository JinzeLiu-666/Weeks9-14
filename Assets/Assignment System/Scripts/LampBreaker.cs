using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LampBreaker : MonoBehaviour
{
    public GameObject can;
    public bool broken = true;

    public void DestroyLamp()
    {
        broken = false;
        can.SetActive(false);
    }
}