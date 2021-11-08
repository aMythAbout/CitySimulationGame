using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{

    [SerializeField] GameObject objToFollow;
    [SerializeField]  float offSet;
    public float timer;
    Vector3 noisePosition;

    // for noise generation
    float heightScale = 5.0f;
    float xScale = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
//noisePosition = changeNoisePosition();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(objToFollow.transform.position.x,
        objToFollow.transform.position.y + offSet + changeNoisePosition(), objToFollow.transform.position.z); // + noisePosition;
        
    }
    float changeNoisePosition()
    {
        // Range over which height varies.

        float height = heightScale * Mathf.PerlinNoise(Time.time * xScale, 0.0f);
        return height;
    }
}
