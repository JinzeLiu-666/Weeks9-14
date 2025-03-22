using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePart : MonoBehaviour
{
    public AnimationCurve growCurve;
    public float growTime = 1f;

    // 改为公开调用，不再在 OnEnable 中触发
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


