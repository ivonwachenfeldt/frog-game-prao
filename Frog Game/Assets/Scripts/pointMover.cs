using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointMover : MonoBehaviour
{
    public bool move;
    public Rigidbody2D rb;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            Vector2 dir = (new Vector2(0, -4) - (Vector2)transform.position).normalized;
            rb.AddForce(dir * 1);
        }


        if (!Input.GetKey(KeyCode.Mouse0))
        {
            move = true;
        }


    }
}