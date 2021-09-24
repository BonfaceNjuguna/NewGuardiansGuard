using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenwrap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        screenWrap();
    }

    private void screenWrap()
    {
        Vector3 playerPos = transform.position;

        Bounds screenExtents = ScreenBorders.ScreenLimits;
        
        //player wrap top and bottom
        if (playerPos.z > screenExtents.max.z)
        {
            playerPos.z = screenExtents.min.z;
        }
        if (playerPos.z < screenExtents.min.z)
        {
            playerPos.z = screenExtents.max.z;
        }

        //wrap left and right
        if (playerPos.x > screenExtents.max.x)
        {
            playerPos.x = screenExtents.min.x;
        }
        if (playerPos.x < screenExtents.min.x)
        {
            playerPos.x = screenExtents.max.x;
        }
        transform.position = playerPos;
    }
}
