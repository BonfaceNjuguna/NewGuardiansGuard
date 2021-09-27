using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAsteroidColliision : MonoBehaviour
{
    //GameOver i;

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
            //i.gameOver();
            shipExplode.Play();
        }
    }
}
