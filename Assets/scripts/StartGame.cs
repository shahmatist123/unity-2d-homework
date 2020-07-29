using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class StartGame : MonoBehaviour
{
    public GameObject buttons, m_cube,spawn_enemy,clickZone, cameraCoub,teach;
    public Text gameName;
    private bool cubeStart = false;
    private void Start()
    {
        teach.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (cubeStart && m_cube)
        {
            CameraCoub();
        }
    }
    private void OnMouseDown()
    {
        buttons.transform.position = new Vector3(1000f, 0, 0);
        gameName.text = "0";
        m_cube.GetComponent<Animation>().Play("cubeStart");
        m_cube.AddComponent<Rigidbody>();
        StartCoroutine(SpawnBlock());
        clickZone.GetComponent<BoxCollider2D>().size = new Vector2(10000, 10000);
    }

    public void CameraCoub()
    {
        cameraCoub.transform.position =  new Vector3(m_cube.transform.position.x +1.3f, m_cube.transform.position.y +4f, m_cube.transform.position.z);
        if (!cubeStart)
        {
            cubeStart = true;
        }
    }
    IEnumerator SpawnBlock()
    {
        
        yield return new WaitForSeconds(1);
        CameraCoub();
        teach.gameObject.SetActive(true);
    }
}
