using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playership : MonoBehaviour
{

    public GameObject Bullet;

    private AudioSource shootBullet;

    public ParticleSystem explosion;

    public Joystick joystick;
    public Joystick lookJoystick;
    public Joybutton joybutton;

    public float speed = 1f;

#if UNITY_ANDROID || UNITY_EDITOR
    //Added angle for movement control
    float angle;
#endif

    void Start()
    {
        shootBullet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID

        MoveJoystick();
        LookJoystick();
        Shoot();
#else
        PCmovement();
        Shoot();
#endif
    }

    //mobile movement
    void MoveJoystick()
    {
        float hoz = joystick.Horizontal;
        float ver = joystick.Vertical;
        Vector3 direction = new Vector3(hoz, 0, ver).normalized;
        transform.Translate(direction * speed, Space.World);
    }

    //mobile rotation
    void LookJoystick()
    {
        //Fixed the movement control, ship snaps to 45 degree angles.
        float hoz = lookJoystick.Horizontal;
        float ver = lookJoystick.Vertical;
        if (!(hoz == 0 && ver == 0))
        {
            Vector3 direction = new Vector3(hoz, 0, ver).normalized;
            angle = Mathf.Atan2(direction.z, direction.x);
            var rotate = transform.eulerAngles;
            rotate.y = -(angle) * Mathf.Rad2Deg + 180;
            //Use rotation instead of LookAt because the player spaceship was rotated strangely
            transform.eulerAngles = rotate;
        }
    }

    public void PCmovement()
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
    }

    /*public void MobileShoot()
    {
        if (joybutton == true)
        {
            //The Bullet instantiation happens here.
            GameObject Bullet_Handler;
            Bullet_Handler = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
            Destroy(Bullet_Handler, 5.0f);

            //audio sound shooting
            shootBullet.Play();
        }
    }*/

    public void Shoot()
    {
        //shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //The Bullet instantiation happens here.
            GameObject Bullet_Handler;
            Bullet_Handler = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
            Destroy(Bullet_Handler, 5.0f);

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
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
