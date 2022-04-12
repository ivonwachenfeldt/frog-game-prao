using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sliderScript : MonoBehaviour
{
    public GameObject handle;
    public GameObject startingPoint;
    public float value;
    public AudioMixer audioMixer;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        value = handle.transform.position.x - startingPoint.transform.position.x;
        audioMixer.SetFloat("volume", Mathf.Log10(value) * 20);
    }
}
