using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public ParticleSystem explosion;
    /*public GameOver gameOver;*/

    private AudioSource earthExplode;

    void Start()
    {
        earthExplode = GetComponents<AudioSource>()[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, -1, 0) * rotationSpeed * Time.deltaTime);   
    }

    /*public void GameOverFunction()
    {
        gameOver.gameOver();
    }*/

    //collision with asteroid
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            Debug.Log("MotherEarth has collided with asteroid");
            Destroy(gameObject);
            earthExplode.Play();
            Instantiate(explosion, transform.position, Quaternion.identity);
            /*Invoke("GameOverFunction", 3);*/
        }
    }
}
