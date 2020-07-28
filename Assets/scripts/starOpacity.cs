using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starOpacity : MonoBehaviour
{
    private SpriteRenderer star;
    void Start()
    {
        star = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        star.color = new Color(star.color.r, star.color.g, star.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
    }
}
