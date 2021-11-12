using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Application.platform != RuntimePlatform.Android)
        {
            //Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
