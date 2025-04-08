using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        clickSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Click()
    {
        clickSound.Play();
    }
}
