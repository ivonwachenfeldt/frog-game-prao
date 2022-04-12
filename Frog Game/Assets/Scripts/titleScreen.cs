using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreen : MonoBehaviour
{
    public Animator animator;
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
            StartCoroutine(sceneLoader("Game"));
        }
        if (col.tag == "SettingsButton")
            StartCoroutine(sceneLoader("Settings"));
        if (col.tag == "TitleButton")
            StartCoroutine(sceneLoader("Title"));
    }
    IEnumerator sceneLoader(string scene)
    {
        animator.SetTrigger("Close");
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(scene);
    }

}
