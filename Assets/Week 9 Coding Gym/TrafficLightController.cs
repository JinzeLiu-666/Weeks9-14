using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrafficLightController : MonoBehaviour
{
    public UnityEvent OnStop;
    public UnityEvent OnGo;

    void Update()
    {
        // left mouse button - Stop
        if (Input.GetMouseButtonDown(0))
        {
            OnStop.Invoke();
        }

        // right mouse button - Go
        if (Input.GetMouseButtonDown(1))
        {
            OnGo.Invoke();
        }
    }
}

