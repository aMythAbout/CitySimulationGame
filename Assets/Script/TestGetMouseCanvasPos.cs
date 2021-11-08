using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGetMouseCanvasPos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 mousePos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Debug.Log(mousePos.x);
        Debug.Log(mousePos.y);
        
    }


}
