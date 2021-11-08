using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPrintData : MonoBehaviour
{
    Text text;
    [SerializeField] GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = "Current Location:" + Camera.transform.position.ToString() + " \nCurrent Direction:" + Camera.transform.rotation.ToEuler().ToString();
    }
}
