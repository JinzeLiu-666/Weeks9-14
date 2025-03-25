using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorButton : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;

    void Start()
    {
        image1.SetActive(true);
        image2.SetActive(false);
    }

    void OnMouseDown()
    {
        image1.SetActive(false);
        image2.SetActive(true);
    }

    public UnityEvent onClick;
    void OnMouseUp()
    {
        image1.SetActive(true);
        image2.SetActive(false);

        onClick.Invoke(); // 鼠标松开时触发事件
    }
}
