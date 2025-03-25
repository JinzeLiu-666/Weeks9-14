using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LampSpawner : MonoBehaviour
{
    public GameObject lampPrefab;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) //  Û±Í”“º¸
        {
            Vector2 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            GameObject newLamp = Instantiate(lampPrefab, mouseWorldPos, Quaternion.identity);

            LampGrow growScript = newLamp.GetComponent<LampGrow>();
            growScript.StartGrow();
        }
    }
}