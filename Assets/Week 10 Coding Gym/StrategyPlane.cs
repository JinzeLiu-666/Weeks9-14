using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyBuilder : MonoBehaviour
{
    public GameObject PlanePrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(PlanePrefab, mouseWorldPos, Quaternion.identity);
        }
    }
}

