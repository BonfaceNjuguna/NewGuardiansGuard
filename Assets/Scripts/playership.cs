using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playership : MonoBehaviour
{

    public GameObject Bullet;

    private AudioSource shootBullet;

    void Start()
    {
        shootBullet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
        }

        //shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //The Bullet instantiation happens here.
            GameObject Bullet_Handler;
            Bullet_Handler = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
            Destroy(Bullet_Handler, 8.0f);

            //audio sound shooting
            shootBullet.Play();
        }
    }

    //collision with the asteroid
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            Destroy(gameObject);
        }
    }
}
