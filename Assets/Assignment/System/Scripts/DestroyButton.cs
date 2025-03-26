using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyButton : MonoBehaviour
{
    public GameObject image1;  // 默认按钮图
    public GameObject image2;  // 按下图
    public UnityEvent onClick; // 使用 UnityEvent 来处理摧毁逻辑

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

    void OnMouseUp()
    {
        image1.SetActive(true);
        image2.SetActive(false);

        onClick.Invoke();
    }
}