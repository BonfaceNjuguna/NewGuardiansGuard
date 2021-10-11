using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMusic : MonoBehaviour
{

    private AudioSource titleMusic;
    // Start is called before the first frame update
    void Start()
    {
        titleMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        titleMusic.Play();
    }
}
