using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampColorChanger : MonoBehaviour
{
    public SpriteRenderer targetRenderer;

    public void ChangeToRandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color newColor = new Color(r, g, b);
        targetRenderer.color = newColor;
    }
}
