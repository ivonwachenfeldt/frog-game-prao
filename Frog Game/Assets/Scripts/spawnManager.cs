using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject fly;
    public GameObject bomb;
    void Start()
    {
        //InvokeRepeating("GenerateFly", 1f, 1f);
    }

    int counter;
    void Update()
    {
        if (counter == 100)
        {
            if (GameObject.FindGameObjectsWithTag("Fly").Length <= 15)
            {
                GenerateFly();
                counter = 0;
            }
        }
        else counter++;


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
        if (Random.Range(1, 20) == 19)
        {
            Instantiate(bomb, coords, transform.rotation);
        }
        else
            Instantiate(fly, coords, transform.rotation);
    }
}

