using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAsteroidCollision : MonoBehaviour
{

    private AudioSource asteroidExplode;
    void Start()
    {
        asteroidExplode = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "bullet")
        {
            asteroidExplode.Play();
        }
    }
}
