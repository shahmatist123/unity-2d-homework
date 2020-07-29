using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        Instantiate(enemy, new Vector3(Random.Range(20, 32), 1, -4.17f), Quaternion.identity);
        Instantiate(enemy, new Vector3(Random.Range(10, 20), 1, -4.17f), Quaternion.identity);
    }

}
