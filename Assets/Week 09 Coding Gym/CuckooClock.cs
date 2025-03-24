using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CuckooClock : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public float hourDuration = 5f;
    public UnityEvent onHourStrike;

    private float timer = 0f;

    void Update()
    {
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= hourDuration)
        {
            timer = 0f;
            onHourStrike.Invoke();
        }
    }
}

