using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRB : MonoBehaviour
{
    Rigidbody rb;

    float Horizontal;
    float Vertical;
    float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the direction facing
        // 
        //rb.velocity = new Vector3(10, 0, 0);
        if (Input.GetKey("up"))
        {
            rb.velocity = transform.forward * speed;
        }
    }
}

