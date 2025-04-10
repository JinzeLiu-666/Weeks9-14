using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LampFlasher : MonoBehaviour
{
    public LampBreaker lampBreaker;
    public ToggleButton toggleButton;
    public FlashButton flashButton;

    public bool isFlashing = false;

    public float speed = 2f;
    public Vector3 star = Vector3.zero;
    public Vector3 end = new Vector3(1.3f, 1.3f, 1.3f);

    // Called by UnityEvent
    public void StartFlashing()
    {
        if (!isFlashing && flashButton.isOn)
        {
            isFlashing = true;
            // Start the flashing coroutine
            StartCoroutine(FlashRoutine());
        }
    }

    // This is the flashing animation coroutine, runs for 5.5 seconds
    IEnumerator FlashRoutine()
    {
        float finalTime = 0f;
        float t = 0f;
        bool goingUp = true;

        // Continue only if time hasn't ended, toggle is on, and the lamp is broken
        while (finalTime < 5.5f && toggleButton.isOn && lampBreaker.broken)
        {
            if (goingUp)
            {
                t += Time.deltaTime * speed;
                if (t >= 1f)
                {
                    t = 1f;
                    // Reached max, start scaling down
                    goingUp = false;
                }
            }
            else
            {
                t -= Time.deltaTime * speed;
                if (t <= 0f)
                {
                    t = 0f;
                    goingUp = true;
                }
            }
            // Smoothly scale between start and end size using t
            transform.localScale = Vector3.Lerp(star, end, t);

            finalTime += Time.deltaTime;
            yield return null;
        }
        // End the animation at max size
        transform.localScale = end;
        isFlashing = false;
        flashButton.isOn = false;
    }
}