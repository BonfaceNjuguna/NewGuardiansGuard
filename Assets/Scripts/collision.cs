using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            Debug.Log("collision");
            Destroy(gameObject);

            var ac = collision.gameObject.GetComponent<asteroid>();
            ac.DestroyAsteroid();

            //ui
            score.instance.AddPoints();
        }        
    }
}
