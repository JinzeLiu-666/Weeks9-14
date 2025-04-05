using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePart : MonoBehaviour
{
    public AnimationCurve growCurve;
    public float growTime = 1f;

    public IEnumerator GrowCoroutine()
    {
        float t = 0f;
        transform.localScale = Vector3.zero;

        while (t < growTime)
        {
            float progress = t / growTime;
            float scaleValue = growCurve.Evaluate(progress);
            transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

            t += Time.deltaTime;
            yield return null;
        }

        transform.localScale = Vector3.one;
    }
}


