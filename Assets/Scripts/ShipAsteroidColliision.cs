using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAsteroidColliision : MonoBehaviour
{
    public GameObject GameOver;

    private AudioSource shipExplode;

    void Start()
    {
        shipExplode = GetComponent<AudioSource>();
    }


    //collision with asteroid
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            Debug.Log("PlayerShip collided with asteroid");

            Destroy(gameObject);
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
        shipExplode.Play();
    }
}
