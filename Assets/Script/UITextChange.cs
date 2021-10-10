using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText("Test Set UI Text");
    }
}
