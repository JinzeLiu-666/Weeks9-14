using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowManager : MonoBehaviour
{
    public PlanePart[] parts;

    void Start()
    {
        StartCoroutine(GrowAllParts());
    }

    IEnumerator GrowAllParts()
    {
        foreach (PlanePart part in parts)
        {
            yield return StartCoroutine(part.GrowCoroutine());
        }
    }
}
