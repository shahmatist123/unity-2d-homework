using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textOpacity : MonoBehaviour
{
    private Text txt;
    private Outline oLine;
    void Start()
    {
        txt = GetComponent<Text>();
        oLine = GetComponent<Outline>();
    }

    void Update()
    {
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, Mathf.PingPong(Time.time/2.0f, 1.0f));
    }
}
