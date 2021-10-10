using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickResponse : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    Material material;
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
           // testClickChangeColor();
            if (Input.GetMouseButtonDown(0)) {
                print(hit.collider.name);
  
            }
        }
    }

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    void OnMouseOver()
    {
        // Change the Color of the GameObject when the mouse hovers over it
        material.color = new Color(0.5f,1,1,0.2f);
        if (Input.GetMouseButtonDown(0))
        {
            print(hit.collider.name);
            print("Cube Clicked!!");
         //   if ()  If camera is close enough
         //   {
                testSceneChange();
         //   }
        }
    }

    void OnMouseExit()
    {
        //Change the Color back to white when the mouse exits the GameObject
        material.color = new Color(1,1,1,0.1f);
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    void testSceneChange()
    {
        GameObject SceneManager;
        SceneManager = GameObject.Find("SceneManager");
        SceneManager.GetComponent < TestNewSceneChange > ().changeToNewScene();
    }
}
