using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyMover : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        FlyMovement();
    }


    void Update()
    {

    }

    void FlyMovement()
    {
        Debug.Log("Move");
        Vector2 direction = new Vector2(Random.Range(0, 1), 1);
        rb.AddForce(direction * 2);
    }
}
