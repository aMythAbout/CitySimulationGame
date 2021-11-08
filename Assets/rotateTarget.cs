using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float heightScale = 1.0f;

        // Distance covered per second along X axis of Perlin plane.
        float xScale = 1.0f;
        float rotateSpeed = heightScale * Mathf.PerlinNoise(Time.time * xScale, 0.0f);
        transform.Rotate(new Vector3(0,rotateSpeed, 0));
    }
}
