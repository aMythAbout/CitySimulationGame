using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 Vec;
    Rigidbody rb;
    // Start is called before the first frame update  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame  
    void FixedUpdate()
    {
        float mouseX = (Input.mousePosition.x / Screen.width) - 0.5f;
        float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
        transform.localRotation = Quaternion.Euler(new Vector4(-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));

        Vec = transform.localPosition;
       // Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;
      //  Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
      //  Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;
        transform.localPosition = Vec;

      //  rb.velocity = new Vector3(Mathf.Clamp(Input.GetAxis("Horizontal") * Time.deltaTime * 200, -25, 25),0,0);
        // rb.velocity = new Vector3(0,0,Mathf.Clamp(Input.GetAxis("Vertical") * Time.deltaTime * 200, -25, 25));
        rb.velocity = transform.forward * Mathf.Clamp(Input.GetAxis("Vertical") * Time.deltaTime * 800, -45, 45);

    }
}
