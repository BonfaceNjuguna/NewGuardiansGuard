using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public GameObject smallAsteroids;
    public ParticleSystem explosion;


    public void DestroyAsteroid()
    {
        if (smallAsteroids != null)
        {
            for (int i = 0; i < 2; ++i)
            {
                var asteroid = Instantiate(smallAsteroids, transform.position - new Vector3(1.0f, 1.0f, 1.0f), Quaternion.identity);
                Vector3 newVelocity = new Vector3(Random.Range(-0.1f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
                asteroid.GetComponent<Rigidbody>().velocity = newVelocity;
            }
        }
        Destroy(gameObject);
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
