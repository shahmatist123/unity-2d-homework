using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runEnemy : MonoBehaviour
{
    public float speed = 5f;
    private bool direction = true;
    void Start()
    {
        if (this.transform.position.x / 2 > 11f)
        {
            speed = Mathf.Abs(speed);
        }
        else
        {
            speed = -Mathf.Abs(speed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x + speed * Time.deltaTime, 1f, -4.3f);
        if (this.transform.position.x > 33f)
        {
            direction = false;
            speed = -Mathf.Abs(speed);
        }
        else if(this.transform.position.x < 10f)
        {
            direction = true;
            speed = Mathf.Abs(speed);
        }
     
    }
}
