using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public ParticleSystem explosion;

    private AudioSource earthExplode;

    void Start()
    {
        earthExplode = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * rotationSpeed * Time.deltaTime);   
    }

    //collision with asteroid
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            Debug.Log("MotherEarth has collided with asteroid");
            earthExplode.Play();
            //Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
