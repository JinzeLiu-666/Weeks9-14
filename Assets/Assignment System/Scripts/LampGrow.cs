using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampGrow : MonoBehaviour
{
    public AnimationCurve growCurve;
    public float growTime = 1f;
    public float targetScale = 0.4f;

    public void StartGrow()
    {
        StartCoroutine(GrowCoroutine());
    }

    private IEnumerator GrowCoroutine()
    {
        float t = 0f;
        transform.localScale = Vector3.zero;

        while (t < growTime)
        {
            float progress = t / growTime;
            float evaluated = growCurve.Evaluate(progress);
            float scaleValue = evaluated * targetScale;

            transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

            t += Time.deltaTime;
            yield return null;
        }

        transform.localScale = new Vector3(targetScale, targetScale, targetScale);
    }
}