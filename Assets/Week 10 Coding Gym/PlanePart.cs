using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePart : MonoBehaviour
{
    public AnimationCurve growCurve;
    public float duration = 1f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Grow());
        }
    }

    IEnumerator Grow()
    {
        float t = 0f;
        Vector3 startScale = Vector3.zero;
        Vector3 endScale = Vector3.one;

        while (t < duration)
        {
            float progress = t / duration;
            float curveValue = growCurve.Evaluate(progress);
            transform.localScale = Vector3.LerpUnclamped(startScale, endScale, curveValue);

            t += Time.deltaTime;
            yield return null;
        }

        transform.localScale = endScale;
    }
}


