using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource clickSound;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        clickSound = GetComponent<AudioSource>();
    }

    public void Click()
    {
        clickSound.Play();
    }
}
