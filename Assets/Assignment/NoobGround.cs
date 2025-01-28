using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class NoobGround : MonoBehaviour
{
    bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When the mouse is clicked move the noob out of the screen
        //Initialize mouse position accounting to world point
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 objectPos = transform.position;
        mousePos.z = 0f;
        if (Input.GetMouseButtonDown(0))
        {
            //Enable click boolean
            clicked = true;
        }
        if (clicked == true)
        {
            objectPos.x -= 0.002f;
        }
        transform.position = objectPos;
    }
}
