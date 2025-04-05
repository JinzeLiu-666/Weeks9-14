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
        StartCoroutine(GrowCoroutine());
    }

    private IEnumerator GrowCoroutine()
    {
        float t = 0f;
        while (t < growTime)
        {
            transform.localScale = Vector3.one * growCurve.Evaluate(t);
            t += Time.deltaTime;
            yield return null;
        }
        transform.localScale = Vector3.one;
    }
}