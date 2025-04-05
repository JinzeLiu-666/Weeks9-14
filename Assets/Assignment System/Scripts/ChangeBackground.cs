using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    public SpriteRenderer backgroundRenderer;

    public Sprite background1;
    public Sprite background2;
    public Sprite background3;
    public Sprite background4;
    public Sprite background5;
    public Sprite background6;

    private int currentIndex = 1;

    public void NextBackground()
    {
        if (currentIndex == 0)
        {
            backgroundRenderer.sprite = background1;
            currentIndex = 1;
        }
        else if (currentIndex == 1)
        {
            backgroundRenderer.sprite = background2;
            currentIndex = 2;
        }
        else if (currentIndex == 2)
        {
            backgroundRenderer.sprite = background3;
            currentIndex = 3;
        }
        else if (currentIndex == 3)
        {
            backgroundRenderer.sprite = background4;
            currentIndex = 4;
        }
        else if (currentIndex == 4)
        {
            backgroundRenderer.sprite = background2;
            currentIndex = 5;
        }
        else if (currentIndex == 5)
        {
            backgroundRenderer.sprite = background3;
            currentIndex = 6;
        }
        else if (currentIndex == 6)
        {
            backgroundRenderer.sprite = background4;
            currentIndex = 0;
        }
    }
}
