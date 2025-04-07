using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    public SpriteRenderer backgroundRenderer;
    public Sprite[] backgrounds;

    private int currentIndex = 0;

    // Change the image by increasing the number when the UnityEvent's click event is triggered.
    public void NextBackground()
    {
        currentIndex = (currentIndex + 1) % backgrounds.Length;
        backgroundRenderer.sprite = backgrounds[currentIndex];
    }
}
