using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyEater : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Fly")
        {
            Destroy(col.gameObject);
        }
    }
}
