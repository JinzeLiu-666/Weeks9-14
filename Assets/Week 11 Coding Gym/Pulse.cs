using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float speed;
    private TrailRenderer trail;
    private bool restart = false;

    void Start()
    {
        trail = GetComponent<TrailRenderer>();
    }

    void Update()
    {
        Vector2 pos = transform.position;
        pos += new Vector2(speed * Time.deltaTime, 0);
        transform.position = pos;

        float star = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
        float end = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;

        if (pos.x > end)
        {
            trail.enabled = false;
            pos.x = star;
            transform.position = pos;
            restart = true;
        }
        if (restart)
        {
            trail.Clear();
            trail.enabled = true;
            restart = false;
        }
    }
}
