using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steering : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] float maxForce;
    [SerializeField] GameObject Target;
    Rigidbody rb;
    Vector3 TargetPos;
    Vector3 currentForce;
    float ArriveDist = 15;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        TargetPos = Target.transform.position;
        Vector3 desired = TargetPos - transform.position;
        Quaternion rotation = Quaternion.LookRotation(desired, Vector3.forward);
        transform.rotation = rotation;
        steering();
    }

    void steering()
    {
        // Steering
        Vector3 desired = TargetPos - transform.position;
        desired.Normalize();
        desired = desired * maxSpeed;
        Vector3 steering = desired - rb.velocity;
        if (steering.magnitude > maxForce)
        {
            steering.Normalize();
            steering = steering * maxForce;
        }
        // Arrive
        float distance = Vector3.Distance(TargetPos, transform.position); 
        if (distance < ArriveDist)
        {
            steering.Normalize();
            steering = steering * (distance / ArriveDist);
        }
        //Debug.Log(steering.magnitude);
        rb.AddForce(steering);
    }

    void arrive()
    {
        //map
        // set steering
    }
}
