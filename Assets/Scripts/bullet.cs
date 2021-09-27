using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 10.0f;

    private AudioSource shootBullet;

    void Start()
    {
        shootBullet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);

        //shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //audio sound shooting
            shootBullet.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            Destroy(gameObject);
        }
    }
}
