using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombMover : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        StartCoroutine(MoveToPoint());
        InvokeRepeating("BombMovement", 3, 3);
    }


    void Update()
    {
        if (Mathf.Abs(transform.position.x) >= 11 || Mathf.Abs(transform.position.y) >= 7)
        {
            Destroy(gameObject);
        }
    }

    void BombMovement()
    {
        if (Random.Range(0, 4) == 1)
            rb.AddForce((new Vector3(0, -4, 0) - transform.position).normalized / 3);
        else
            rb.velocity = Random.onUnitSphere;
    }
    IEnumerator MoveToPoint()
    {
        yield return new WaitForSeconds(Random.Range(0f, 4f));
        Vector2 point = new Vector2(Random.Range(-6f, 6f), Random.Range(-2f, 3.5f));
        rb.AddForce((point - (Vector2)transform.position).normalized / 5);
    }
}
