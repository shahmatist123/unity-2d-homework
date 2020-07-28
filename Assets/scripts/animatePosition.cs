using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatePosition : MonoBehaviour
{
    public float speed = 5f, checkpos = 0f;
    private RectTransform rect;

    void Start()
    {
        rect = GetComponent <RectTransform>();
    }
    private void Update()
    {
        if (rect.offsetMin.y != checkpos)
        {
            rect.offsetMin += new Vector2(rect.offsetMin.x, speed);
            rect.offsetMax += new Vector2(rect.offsetMax.x, speed);
        }
    }
}
