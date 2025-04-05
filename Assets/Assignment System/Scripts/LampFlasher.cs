using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LampFlasher : MonoBehaviour
{
    public ToggleButton ToggleButton;
    public FlashButton FlashButton;
    public bool isFlashing = false;

    public Vector3 star = Vector3.zero;
    public Vector3 end = new Vector3(1.3f, 1.3f, 1.3f);
    public float speed = 2f;

    public void StartFlashing()
    {
        if (!isFlashing && ToggleButton.isOn && FlashButton.isOn)
        {
            isFlashing = true;
            StartCoroutine(FlashRoutine());
        }
    }

    IEnumerator FlashRoutine()
    {
        float finalTime = 0f;
        float t = 0f;
        bool goingUp = true;

        while (finalTime < 5f && ToggleButton.isOn)
        {
            if (goingUp)
            {
                t += Time.deltaTime * speed;
                if (t >= 1f)
                {
                    t = 1f;
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
            transform.localScale = Vector3.Lerp(star, end, t);

            finalTime += Time.deltaTime;
            yield return null;
        }
        transform.localScale = star;
        isFlashing = false;
        FlashButton.isOn = false;
    }
}