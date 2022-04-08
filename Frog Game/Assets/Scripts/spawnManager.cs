using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject fly;
    void Start()
    {
        InvokeRepeating("GenerateFly", 1f, 1f);
    }


    void Update()
    {



    }
    void GenerateFly()
    {
        Instantiate(fly, new Vector2(Random.Range(-8.25f, 8.25f), Random.Range(-2.5f, 4.5f)), transform.rotation);
    }
}

