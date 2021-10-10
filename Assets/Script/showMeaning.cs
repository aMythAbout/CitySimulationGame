using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showMeaning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(2,0,0);
    }

    public void show()
    {
        var cubeRenderer = this.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        
        cubeRenderer.material.SetColor("_Color", new Color(0.1f,0.9f,0.5f,0.3f));
    }
}
