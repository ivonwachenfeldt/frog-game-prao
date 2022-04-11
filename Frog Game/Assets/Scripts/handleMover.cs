using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handleMover : MonoBehaviour
{
    public Rigidbody2D rb;
    bool ready = false;
    void Start()
    {
        InvokeRepeating("FlyMovement", 4, 4);
    }


    void Update()
    {
        if (Mathf.Abs(transform.position.x) >= 11 || Mathf.Abs(transform.position.y) >= 7)
        {
            Destroy(gameObject);
        }
        //if (ready)
        //if (Mathf.Abs(rb.velocity.x) <= 0.5f && Mathf.Abs(rb.velocity.y) <= 0.5f)
        //FlyMovement();
    }

    void FlyMovement()
    {
        rb.velocity = Random.onUnitSphere;
    }
    IEnumerator MoveToPoint()
    {
        yield return new WaitForSeconds(Random.Range(0f, 4f));
        ready = true;
        Vector2 point = new Vector2(Random.Range(-6f, 6f), Random.Range(-2f, 3.5f));
        rb.AddForce((point - (Vector2)transform.position).normalized / 250);
    }
}
