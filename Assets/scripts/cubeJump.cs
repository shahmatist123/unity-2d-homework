using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubeJump : MonoBehaviour
{
    public GameObject mainCube, teach;
    private bool animate;
    public float scratchSpeed = 0.5f;
    private float startTime;
    private void FixedUpdate()
    { 
        if (mainCube)
        {
            if (mainCube.GetComponent<Rigidbody>() && mainCube.transform.localScale.y > 0.4f && animate)
            {
                mainCube.transform.localPosition -= new Vector3(0f, scratchSpeed * Time.deltaTime, 0f);
                mainCube.transform.localScale -= new Vector3(0f, scratchSpeed * Time.deltaTime, 0f);
            }
            else if (animate == false && mainCube.transform.localScale.y < 0.69f)
            {
                mainCube.transform.localPosition += new Vector3(0f, scratchSpeed * Time.deltaTime * 2, 0f);
                mainCube.transform.localScale += new Vector3(0f, scratchSpeed * Time.deltaTime * 2, 0f);
            }
            if (mainCube.transform.localPosition.y < -7f)
            {
                SceneManager.LoadScene("restart", LoadSceneMode.Single);
            }
        }
    }
    private void OnMouseDown()
    {
        if (mainCube.GetComponent <Rigidbody>() && mainCube.transform.localScale.y > 0.4f)
        {
            animate = true;
            startTime = Time.time;
        }
    }
    private void OnMouseUp()
    {
        if (mainCube.GetComponent<Rigidbody>())
        {
            animate = false;
            float force, diff;
            diff = Time.time - startTime;
            if (diff < 1f)
            {
                force = 200 * diff;
            }
            else
            {
                force = 200f;
            }
            if (force < 60f)
            {
                force = 60f;
            }
            mainCube.GetComponent<Rigidbody>().AddForce(mainCube.transform.up * force * 2f);
            mainCube.GetComponent<Rigidbody>().AddRelativeForce(mainCube.transform.right * force);
            mainCube.GetComponent <Rigidbody>().freezeRotation = true;
            teach.gameObject.SetActive(false);
        }
    }
}
