using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject buttons;
    public Text gameName;
    private void OnMouseDown()
    {
        buttons.gameObject.SetActive(false);
        gameName.text = "0";
    }
}
