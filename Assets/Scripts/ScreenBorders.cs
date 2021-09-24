using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBorders : MonoBehaviour
{

    public static float padding = 1.0f;
    public static Bounds ScreenLimits
    {
        get
        {
            Camera c = Camera.main;
            float o = c.transform.position.y;

            float yextent = Mathf.Tan(c.fieldOfView / 2 * Mathf.Deg2Rad) * o * 2;
            float xextent = yextent * c.aspect;
            Bounds box = new Bounds(new Vector3(), new Vector3(xextent + padding * 2, 0, yextent + padding * 2));
            return box;
        }
    }

    public float pad = 1.0f;

    private void OnValidate()
    {
        padding = pad;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(ScreenLimits.center, ScreenLimits.size);
    }
}
