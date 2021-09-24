using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public GameObject Bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //The Bullet instantiation happens here.
            GameObject Bullet_Handler;
            Bullet_Handler = Instantiate(Bullet) as GameObject;
            Bullet.transform.position = transform.position;
            Bullet.transform.rotation = transform.rotation;
            Destroy(Bullet_Handler, 8.0f);
        }
    }
}
