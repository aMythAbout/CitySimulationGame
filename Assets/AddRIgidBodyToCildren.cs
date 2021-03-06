using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRIgidBodyToCildren : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        addRigidBodyToChild();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addRigidBodyToChild()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.AddComponent<Rigidbody>();
            Rigidbody rb = child.gameObject.GetComponent<Rigidbody>();
            rb.mass = 200;
            rb.useGravity = true;
        }
    }
}
