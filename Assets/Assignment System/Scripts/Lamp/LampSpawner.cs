using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LampSpawner : MonoBehaviour
{
    public GameObject lampPrefab;
    public ChangeBackground backgroundChanger;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // Convert the mouse position into a world position
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Create a new lamp at that position
            GameObject newLamp = Instantiate(lampPrefab, mouseWorldPos, Quaternion.identity);
        }
    }
}