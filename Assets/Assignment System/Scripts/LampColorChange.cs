using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampColorChanger : MonoBehaviour
{
    public SpriteRenderer targetRenderer;

    // Called by UnityEvent
    public void ChangeToRandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        // Create a new color using the random RGB values
        Color newColor = new Color(r, g, b);
        targetRenderer.color = newColor;
    }
}