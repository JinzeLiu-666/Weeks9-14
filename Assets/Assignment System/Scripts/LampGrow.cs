using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampGrow : MonoBehaviour
{
    public AnimationCurve growCurve;
    [Range(0.1f, 2f)]
    public float growTime = 1f;

    void Start()
    {
        // Start the growth at the beginning
        StartCoroutine(GrowCoroutine());
    }

    private IEnumerator GrowCoroutine()
    {
        float t = 0f;
        while (t < growTime)
        {
            // Use the animation curve to decide how big the object should be at time t
            transform.localScale = Vector3.one * growCurve.Evaluate(t);
            t += Time.deltaTime;
            yield return null;
        }
        transform.localScale = Vector3.one;
    }
}