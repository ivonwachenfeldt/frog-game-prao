using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flyEater : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject frog;
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
            FindObjectOfType<AudioManager>().Play("getPoint");
            Destroy(col.gameObject);
            score++;
            scoreText.text = score + "";
            Debug.Log(score);
            this.gameObject.transform.localScale = new Vector3((float)score / 600f + 2, 2, 1);
        }
        if (col.tag == "Bomb")
        {
            Debug.Log("GAMEOVER");
        }
    }
}
