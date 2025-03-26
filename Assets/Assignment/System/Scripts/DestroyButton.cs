using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyButton : MonoBehaviour
{
    public GameObject image1;  // Ĭ�ϰ�ťͼ
    public GameObject image2;  // ����ͼ
    public UnityEvent onClick; // ʹ�� UnityEvent ������ݻ��߼�

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