using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flyEater : MonoBehaviour
{
    public int score;
    public Text scoreText;
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Fly")
        {
            Destroy(col.gameObject);
            score++;
            scoreText.text = score + "";
            Debug.Log(score);
        }
    }
}
