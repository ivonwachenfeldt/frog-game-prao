using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "PlayButton")
        {
            SceneManager.LoadScene("Game");
        }
        if (col.tag == "SettingsButton")
            SceneManager.LoadScene("Settings");
        if (col.tag == "TitleButton")
            SceneManager.LoadScene("Title");
    }

}
