using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyMaterialToChild : MonoBehaviour
{
    [SerializeField] float MaterialToApply;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            Material childMaterial = child.gameObject.GetComponent<MeshRenderer>().material;
            //childMaterial =  Resources.Load("/Materials/mymaterial", typeoff(Material)) as Material;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
