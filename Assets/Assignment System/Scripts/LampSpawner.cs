using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LampSpawner : MonoBehaviour
{
    public GameObject lampPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newLamp = Instantiate(lampPrefab, mouseWorldPos, Quaternion.identity);
        }
    }
}