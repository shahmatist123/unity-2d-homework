using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour
{
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());
        
    }
    IEnumerator spawn()
    {
        while (true) {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), 1.0f));
            Instantiate(star, pos, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }

}
