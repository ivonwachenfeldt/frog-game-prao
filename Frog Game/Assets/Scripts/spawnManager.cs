using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject fly;
    void Start()
    {
        //InvokeRepeating("GenerateFly", 1f, 1f);
    }


    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Fly").Length <= 150)
        {
            GenerateFly();
        }
    }
    Vector2 coords;
    int randomized;
    void GenerateFly()
    {
        randomized = Random.Range(0, 2);
        if (randomized == 0)
            coords = new Vector2(10, Random.Range(-2.5f, 4.5f));
        if (randomized == 1)
            coords = new Vector2(-10, Random.Range(-2.5f, 4.5f));
        if (randomized == 2)
            coords = new Vector2(Random.Range(-8.5f, 8.5f), 5);
        Instantiate(fly, coords, transform.rotation);
    }
}

